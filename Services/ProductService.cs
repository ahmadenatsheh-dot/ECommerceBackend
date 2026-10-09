using ECommerceBackend.Interfaces;
using ECommerceBackend.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerceBackend.Services
{
    public class ProductService : IProductService
    {
        private List <Product> products = new List<Product>();
        public void AddProduct(Product product)
        {
            Console.WriteLine($"Products count: {products.Count + 1}");

            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine($"Checking ID: {products[i].Id}");

                if (products[i].Id == product.Id)
                {
                    Console.WriteLine($"Product with Id {product.Id} already exists.");
                    return;
                }
            }

            products.Add(product);
            Console.WriteLine("Product added successfully.");
        }
        public void RemoveProduct (Product product)
        {
           products.Remove(product);
        }
        public void RemoveProductById(int id)
        {
            var product = products.Find(product => product.Id == id);
            if(product != null)
            {
                products.Remove(product);
            }
            else
            {
                Console.WriteLine($"Product with Id {id} not found.");
            }
        }
        public void UpdateProduct (Product product) 
        {
          
            var exsitingproduct = products.Find(p => p.Id == product.Id);
            
                
                if(exsitingproduct !=null)
                {
                    exsitingproduct.Name = product.Name;
                    exsitingproduct.Price = product.Price;
                    exsitingproduct.Stock = product.Stock;
                    exsitingproduct.ExpirationDate = product.ExpirationDate;
                Console.WriteLine($"Product with Id {product.Id} updated successfully.");
            }
            else
            {
                Console.WriteLine($"Product with Id {product.Id} not found.");
            }
            
        }
        public Product GetProductById(int Id)
        {
            var product = products.Find(product => product.Id == Id);
            if(product !=null)
            {
                Console.WriteLine($"Product : {product.Name}\n Price : {product.Price}\n Stock: {product.Stock}\n Expiration Date: {product.ExpirationDate}");
                return product;
            }
            else
            {
                Console.WriteLine($"Product with Id {Id} not found.");
                return null;
            }
        }
        public List<Product> GetAllProducts()
        {
            var P = new List<Product>();
            if (products.Count > 0 )
            {
                foreach(var p in products)
                {
                    Console.WriteLine($"Product : {p.Name}\n Proce : {p.Price}\n Stock: {p.Stock}\n Expiration Date: {p.ExpirationDate}");
                    P.Add(p);
                }
                return P;
            }
            else
            {
                Console.WriteLine("No products found.");
                return null;
            }
        }
        
        public List<Product> SearchByName (IProductService.ProductFilter filter)
        {
            var result = new List<Product>();
            foreach(var p in products)
            {
                if(filter(p))
                {
                    Console.WriteLine($"Product : {p.Name}\n Proce : {p.Price}\n Stock: {p.Stock}\n Expiration Date: {p.ExpirationDate}");
                    result.Add(p);
                }
                
            }
            return result;
        }
    }
}
