using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerceBackend.Models
{
    public class ElectronicProduct : Product
    {
        public ElectronicProduct(int id, string name, decimal price, int stock)
            : base (id, name, price, stock)
        {

        }
    }
}
