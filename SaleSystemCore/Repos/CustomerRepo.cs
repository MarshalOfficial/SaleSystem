using Microsoft.EntityFrameworkCore;
using SaleSystemCore.EF;
using SaleSystemCore.Models;
using SaleSystemCore.Repos.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SaleSystemCore.Repos
{
    public class CustomerRepo : RepoBase<Customer>
    {
        public CustomerRepo(DbContextOptions<CoreContext> options)
            : base(options)
        { }
        public CustomerRepo()
        { }

        public override IEnumerable<Customer> GetAll()
            => Table.AsNoTracking().OrderBy(x => x.Id);
        public override IEnumerable<Customer> GetRange(int skip, int take)
            => GetRange(Table.AsNoTracking().OrderBy(x => x.Id), skip, take);

        public Customer GetCustomerByMobile(string mobile)
        {
            return Table.FirstOrDefault(l => l.Mobile == mobile);
        }
    }
}
