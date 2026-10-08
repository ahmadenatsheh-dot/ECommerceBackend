using ECommerceBackend.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerceBackend.Services
{
    public class SmsService : IHelpSender
    {
        public async Task Send(string message)
        {
            Console.WriteLine($"sending SMS: {message}");
            await Task.Delay(500);
            Console.WriteLine("SMS sent successfully.");
        }

    }
}
