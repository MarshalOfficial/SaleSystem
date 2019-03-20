using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DNTPersianUtils.Core;
using Microsoft.EntityFrameworkCore;
using SaleSystemCore.EF;
using SaleSystemCore.Models;
using SaleSystemCore.Repos.Base;

namespace SaleSystemCore.Repos
{
    public class ProductRepo : RepoBase<Product>
    {
        public ProductRepo(DbContextOptions<CoreContext> options)
            : base(options)
        { }
        public ProductRepo()
        { }

        public override IEnumerable<Product> GetAll()
            => Table.AsNoTracking().OrderBy(x => x.Name);
        public override IEnumerable<Product> GetRange(int skip, int take)
            => GetRange(Table.AsNoTracking().OrderBy(x => x.Name), skip, take);

        public Product GetProductByBarcode(string code)
        {
            return Table.AsNoTracking().FirstOrDefault(l => l.Barcode == code);
        }

        public IEnumerable<Product> SearchProductByName(string name)
        {
            var txt = name.ToEnglishNumbers().ApplyCorrectYeKe();
            return Table.AsNoTracking().Where(l => l.Name.Contains(txt));
        }
    }
}