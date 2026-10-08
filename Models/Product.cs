using ECommerceBackend.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ECommerceBackend.Models
{
    public class Product : IProduct
    {
        public Product(int id , string name , decimal price , int stock, DateTime? expirationDate)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
            this.Stock = stock;
            this.ExpirationDate = expirationDate;
        }
        private int id;
        private string name;
        private decimal price;
        private int stock;

        private DateTime? expirationDate;


        public int Id 
        {
            get { return id; }
            set
            {
                if (value > 0)
                    id = value;
            }
        }
        public string Name 
        { get { return name; }
            set
            {
                    if (!string.IsNullOrWhiteSpace(value))
                        name = value;
                
            }
        }
        public decimal Price
        {
            get { return price; }
            set
            {
                    if (value >= 0)
                        price = value;
            }
                
            
        }
        public int Stock { get { return stock; }
            set
            {
               if(value>=0)
                    stock = value;
               
            }
        }
        public DateTime? ExpirationDate 
        { 
            get { return expirationDate; }
            set
            {
                if (value == null || value > DateTime.Now )
                    expirationDate = value;
            }
        }
        public bool IsExpired ()

        {
            return ExpirationDate.HasValue && ExpirationDate.Value < DateTime.Now;
        }
    }
}
