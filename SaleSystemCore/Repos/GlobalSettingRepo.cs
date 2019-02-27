using SaleSystemCore.Repos.Base;
using System;
using System.Collections.Generic;
using System.Text;
using SaleSystemCore.Models;
using Microsoft.EntityFrameworkCore;
using SaleSystemCore.EF;

namespace SaleSystemCore.Repos
{
    public class GlobalSettingRepo : RepoBase<GlobalSetting>
    {
        public GlobalSettingRepo(DbContextOptions<CoreContext> options)
            : base(options)
        { }
        public GlobalSettingRepo()
        { }
        
    }
}
