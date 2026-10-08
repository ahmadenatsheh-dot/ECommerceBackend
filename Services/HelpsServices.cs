using ECommerceBackend.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace ECommerceBackend.Services
{
    public class HelpsServices 
    {
        public readonly IHelpSender _helpSender;
        public HelpsServices(IHelpSender helpSender)
        {
            _helpSender = helpSender;
        }
        public async Task SendHelpMessage(string message)
        {
            await _helpSender.Send(message);
        }

    }
}
