using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerceBackend.Interfaces
{
    public interface IProduct
    {
         int Id { get ; }
         string Name { get; }
         decimal Price { get; }
         int Stock { get; }
    }
}
