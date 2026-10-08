using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerceBackend.Helpers
{
    public class InputHelper
    {
        public int ReadInt()
        {
            return Convert.ToInt32(Console.ReadLine());
        }
        public decimal ReadDecimal()
        {
            return Convert.ToDecimal(Console.ReadLine());
        }
        public string ReadString()
        {
            return Console.ReadLine();
        }
        public DateTime? ReadDate()
        {
            string input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
            {
                return null;
            }
            else
            {
                return Convert.ToDateTime(input);
            }
        }

    }
}
