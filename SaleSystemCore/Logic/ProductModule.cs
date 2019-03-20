using SaleSystemCore.Models;
using SaleSystemCore.Repos;
using System;
using System.Collections.Generic;
using System.Text;

namespace SaleSystemCore.Logic
{
    public class ProductModule
    {
        private ProductRepo productRepo;
        private ProductsBrandRepo productsBrandRepo;
        private ProductsCategoryRepo productsCategoryRepo;
        private ProductsProviderRepo productsProviderRepo;


        internal ProductModule()
        {
            productRepo = new ProductRepo();
            productsBrandRepo = new ProductsBrandRepo();
            productsCategoryRepo = new ProductsCategoryRepo();
            productsProviderRepo = new ProductsProviderRepo();
        }

        #region [Product]
        public void AddProduct(Product product)
        {
            productRepo.Add(product);
        }
        public IEnumerable<Product> GetAllProducts()
        {
            return productRepo.GetAll();
        }
        public Product GetProduct(int id)
        {
            return productRepo.Find(id);
        }
        public void SaveProduct()
        {
            productRepo.SaveChanges();
        }
        public void DeleteProduct(Product product)
        {
            productRepo.Delete(product);
        }
        public Product GetProductByBarcode(string barcode)
        {
            return productRepo.GetProductByBarcode(barcode);
        }

        public IEnumerable<Product> SearchProductByName(string name)
        {
            return productRepo.SearchProductByName(name);
        }
        #endregion

        #region [ProductBrand]
        public void AddProductBrand(ProductsBrand productsBrand)
        {
            productsBrandRepo.Add(productsBrand);
        }

        public IEnumerable<ProductsBrand> GetAllProductBrands()
        {
            return productsBrandRepo.GetAll();
        }

        public ProductsBrand GetProductBrand(int id)
        {
            return productsBrandRepo.Find(id);
        }

        public void SaveProductBrand()
        {
            productsBrandRepo.SaveChanges();
        }

        public void DeleteProductBrand(ProductsBrand productsBrand)
        {
            productsBrandRepo.Delete(productsBrand);
        }
        #endregion

        #region [ProductCategory]
        public void AddProductCategory(ProductsCategory productsCategory)
        {
            productsCategoryRepo.Add(productsCategory);
        }

        public IEnumerable<ProductsCategory> GetAllProductCategories()
        {
            return productsCategoryRepo.GetAll();
        }

        public ProductsCategory GetProductCategory(int id)
        {
            return productsCategoryRepo.Find(id);
        }

        public void SaveProductCategory()
        {
            productsCategoryRepo.SaveChanges();
        }

        public void DeleteProductCategory(ProductsCategory productsCategory)
        {
            productsCategoryRepo.Delete(productsCategory);
        }
        #endregion

        #region [ProductProvider]
        public void AddProductProvider(ProductsProvider productsProvider)
        {
            productsProviderRepo.Add(productsProvider);
        }

        public IEnumerable<ProductsProvider> GetAllProductProvideres()
        {
            return productsProviderRepo.GetAll();
        }

        public ProductsProvider GetProductProvider(int id)
        {
            return productsProviderRepo.Find(id);
        }

        public void SaveProductProvider()
        {
            productsProviderRepo.SaveChanges();
        }

        public void DeleteProductProvider(ProductsProvider productsProvider)
        {
            productsProviderRepo.Delete(productsProvider);
        }
        #endregion
    }
}
