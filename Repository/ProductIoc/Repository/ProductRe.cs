using Repository.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Repository.Repository
{
    public class ProductRe : IProduct
    {
        private ProductDB container;
        public ProductRe(ProductDB product)
        {
            this.container = product;
        }
        public void InsertProduct(Models.Product product)
        {
            container.Products.Add(product);
            container.SaveChanges();
        }
        public IEnumerable<Models.Product> GetProducts()
        {
            return container.Products.ToList();
        }
        public Models.Product GetProductByID(int ProductID)
        {
            return container.Products.Find(ProductID);
        }
        public void UpdateProduct(Models.Product product)
        {
            container.Entry(product).State = EntityState.Modified;
            container.SaveChanges();
        }
        public void DeleteProduct(int ProductID)
        {
            Product user = container.Products.Find(ProductID);
            container.Products.Remove(user);
            container.SaveChanges();
        }
        public void Save()
        {
            container.SaveChanges();
        }

        public IEnumerable<Product> FindProductByName(string ProductName)
        {
            if (ProductName.Trim().Length == 0)
            {
                return container.Products.Select(p => p).ToList();
            }
            else
            {
                return container.Products.Where(p => p.ProductName.Contains(ProductName)).ToList();
            }
        }
    }
}