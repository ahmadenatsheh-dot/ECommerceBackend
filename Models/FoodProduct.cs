using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerceBackend.Models
{
    internal class FoodProduct : Product
    {
        public FoodProduct(int id, string name, decimal price, int stock, DateTime expirationDate)
            : base(id, name, price, stock, expirationDate)
        {
        }
    
    }
}
