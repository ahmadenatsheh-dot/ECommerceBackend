using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerceBackend.Interfaces
{
    public interface IHelpSender
    {
         Task Send (string message);
    }
}
