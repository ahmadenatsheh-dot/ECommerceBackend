using System;
using System.Collections.Generic;
using System.Text;
using ECommerceBackend.Models;
namespace ECommerceBackend.Interfaces
{
   public interface  IProductService
    {
        public void AddProduct(Product product);
        public void RemoveProduct(Product product);
        public void UpdateProduct(Product product);
        public Product GetProductById(int Id);
        public List<Product> GetAllProducts();
        public void RemoveProductById(int id);
        public List<Product> SearchByName(ProductFilter filter);
        public delegate bool ProductFilter(Product product);
    }
}
