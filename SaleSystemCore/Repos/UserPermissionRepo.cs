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
    public class UserPermissionRepo : RepoBase<UserPermissions>
    {
        public UserPermissionRepo(DbContextOptions<CoreContext> options)
            : base(options)
        { }
        public UserPermissionRepo()
        { }

        public override IEnumerable<UserPermissions> GetAll()
            => Table.AsNoTracking().OrderBy(x => x.Id);
        public override IEnumerable<UserPermissions> GetRange(int skip, int take)
            => GetRange(Table.AsNoTracking().OrderBy(x => x.Id), skip, take);

        public List<UserPermissions> GetUserPermissions(int userid) =>  
            Table.AsNoTracking().Where(l => l.UserID == userid).ToList();       
    }
}
