using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using SaleSystemCore.EF;
using SaleSystemCore.Models;
using Microsoft.EntityFrameworkCore.Storage;
using System.Linq;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace SaleSystemCore.Repos.Base
{
    public abstract class RepoBase<T> : IDisposable, IRepo<T> where T : EntityBase, new()
    {
        protected DbSet<T> Table;
        protected readonly CoreContext Db;
        protected RepoBase()
        {
            Db = new CoreContext();
            Table = Db.Set<T>();
        }
        protected RepoBase(DbContextOptions<CoreContext> options)
        {
            Db = new CoreContext(options);
            Table = Db.Set<T>();
        }


        public virtual int Add(T entity, bool persist = true)
        {
            Table.Add(entity);
            return persist ? SaveChanges() : 0;
        }
        public virtual int AddRange(IEnumerable<T> entities, bool persist = true)
        {
            Table.AddRange(entities);
            return persist ? SaveChanges() : 0;
        }
        public virtual int Update(T entity, bool persist = true)
        {
            Table.Update(entity);
            return persist ? SaveChanges() : 0;
        }
        public virtual int UpdateRange(IEnumerable<T> entities, bool persist = true)
        {
            Table.UpdateRange(entities);
            return persist ? SaveChanges() : 0;
        }
        public virtual int Delete(T entity, bool persist = true)
        {
            Table.Remove(entity);
            return persist ? SaveChanges() : 0;
        }

        public int Delete(int id, byte[] timeStamp, bool persist = true)
        {
            var entry = GetEntryFromChangeTracker(id);
            if (entry != null)
            {
                if (entry.TimeStamp == timeStamp)
                {
                    return Delete(entry, persist);
                }
                throw new Exception("Unable to delete due to concurrency violation.");
            }
            Db.Entry(new T { Id = id, TimeStamp = timeStamp }).State = EntityState.Deleted;
            return persist ? SaveChanges() : 0;
        }

        public virtual int DeleteRange(IEnumerable<T> entities, bool persist = true)
        {
            Table.RemoveRange(entities);
            return persist ? SaveChanges() : 0;
        }

        internal T GetEntryFromChangeTracker(int? id)
        {
            return Db.ChangeTracker.Entries<T>().Select((EntityEntry e) => (T)e.Entity)
                .FirstOrDefault(x => x.Id == id);
        }

        public T Find(int? id) => Table.Find(id);
        public T GetFirst() => Table.AsNoTracking().FirstOrDefault();
        public virtual IEnumerable<T> GetAll() => Table.AsNoTracking();
        internal IEnumerable<T> GetRange(IQueryable<T> query, int skip, int take)
            => query.AsNoTracking().Skip(skip).Take(take);
        public virtual IEnumerable<T> GetRange(int skip, int take)
            => GetRange(Table, skip, take);

        public bool HasChanges => Db.ChangeTracker.HasChanges();
        public int Count => Table.Count();

        public int SaveChanges()
        {
            try
            {
                return Db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                //A concurrency error occurred
                //Should handle intelligently
                Console.WriteLine(ex);
                throw;
            }
            catch (RetryLimitExceededException ex)
            {
                //DbResiliency retry limit exceeded
                //Should handle intelligently
                Console.WriteLine(ex);
                throw;
            }
            catch (Exception ex)
            {
                //Should handle intelligently
                Console.WriteLine(ex);
                throw;
            }
        }


        bool _disposed = false;

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (_disposed) return;
            if (disposing)
            {
                // Free any other managed objects here.
                //
            }
            Db.Dispose();
            _disposed = true;
        }
    }
}
