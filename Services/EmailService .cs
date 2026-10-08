using ECommerceBackend.Interfaces;

namespace ECommerceBackend.Services
{
    public class EmailService : IHelpSender
    {
        public async Task Send(string message)
        {
            Console.WriteLine($"Sending Email: {message}");

            await Task.Delay(500);

            Console.WriteLine("Email sent successfully.");
        }
    }
}