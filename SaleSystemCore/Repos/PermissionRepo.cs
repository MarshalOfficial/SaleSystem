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
    public class PermissionRepo : RepoBase<Permission>
    {
        public PermissionRepo(DbContextOptions<CoreContext> options)
            : base(options)
        { }
        public PermissionRepo()
        { }

        public override IEnumerable<Permission> GetAll()
            => Table.AsNoTracking().Where(l => !l.IsDeleted).AsNoTracking().OrderBy(x => x.Id);
        public override IEnumerable<Permission> GetRange(int skip, int take)
            => GetRange(Table.AsNoTracking().Where(l => !l.IsDeleted).OrderBy(x => x.Id), skip, take);
    }
}
