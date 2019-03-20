using Microsoft.EntityFrameworkCore;
using SaleSystemCore.EF;
using SaleSystemCore.Models;
using SaleSystemCore.Repos.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SaleSystemCore.Extension;

namespace SaleSystemCore.Repos
{
    public class UserRepo : RepoBase<User>
    {
        public UserRepo(DbContextOptions<CoreContext> options)
            : base(options)
        { }
        public UserRepo()
        { }

        public override IEnumerable<User> GetAll()
            => Table.AsNoTracking().OrderBy(x => x.Id);
        public override IEnumerable<User> GetRange(int skip, int take)
            => GetRange(Table.AsNoTracking().OrderBy(x => x.Id), skip, take);

        public User FindByCredentials(string username, string password) =>
            Table.AsNoTracking().FirstOrDefault(l => l.UserName == username && l.Password == password.HashString());
    }
}
