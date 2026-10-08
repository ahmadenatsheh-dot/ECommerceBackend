using ECommerceBackend.Models;
using ECommerceBackend.Services;
using ECommerceBackend.Helpers;
namespace ECommerceBackend
{
    
    internal  class Program
    {

        
        
            static async Task Main(string[] args)
            {
                var productService = new ProductService();
                var inputHelper = new InputHelper();

                int choice;

                do
                {
                    Console.WriteLine(
                        "Welcome to the E-Commerce Backend!\n" +
                        "1. Add Product\n" +
                        "2. Remove Product By Id\n" +
                        "3. Update Product\n" +
                        "4. Get Product By Id\n" +
                        "5. Get All Products\n" +
                        "6. Search Product By Name\n" +
                        "7. Send Help Message\n" +
                        "8. Exit"
                    );

                    choice = inputHelper.ReadInt();

                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Enter Product Id:");
                            int id = inputHelper.ReadInt();

                            Console.WriteLine("Enter Product Name:");
                            string name = inputHelper.ReadString();

                            Console.WriteLine("Enter Product Price:");
                            decimal price = inputHelper.ReadDecimal();

                            Console.WriteLine("Enter Product Stock:");
                            int stock = inputHelper.ReadInt();

                            Console.WriteLine("Enter Product Expiration Date (yyyy-MM-dd) or leave blank for no expiration date:");
                            DateTime? expirationDate = inputHelper.ReadDate();

                            Product product = new Product(
                                id,
                                name,
                                price,
                                stock,
                                expirationDate
                            );

                            productService.AddProduct(product);
                            break;

                        case 2:
                            Console.WriteLine("Enter Product Id:");
                            id = inputHelper.ReadInt();

                            productService.RemoveProductById(id);
                            break;

                        case 3:
                            Console.WriteLine("Enter Product Id you want to update:");
                            id = inputHelper.ReadInt();

                            Console.WriteLine("Enter new Product Name:");
                            name = inputHelper.ReadString();

                            Console.WriteLine("Enter new Product Price:");
                            price = inputHelper.ReadDecimal();

                            Console.WriteLine("Enter new Product Stock:");
                            stock = inputHelper.ReadInt();

                            Console.WriteLine("Enter new Product Expiration Date (yyyy-MM-dd) or leave blank for no expiration date:");
                            expirationDate = inputHelper.ReadDate();

                            product = new Product(
                                id,
                                name,
                                price,
                                stock,
                                expirationDate
                            );

                            productService.UpdateProduct(product);
                            break;

                        case 4:
                            Console.WriteLine("Enter Product Id:");
                            id = inputHelper.ReadInt();

                            productService.GetProductById(id);
                            break;

                        case 5:
                            productService.GetAllProducts();
                            break;

                        case 6:
                            Console.WriteLine("Enter Product Name:");
                            name = inputHelper.ReadString();

                            productService.SearchByName(name);
                            break;

                        case 7:
                            Console.WriteLine("Enter Help Message:");
                            string helpMessage = inputHelper.ReadString();

                            var helpService = new HelpsServices();

                            helpService.sendEmail(helpMessage, helpService);
                            await helpService.sendSMS(helpMessage, helpService);
                            break;

                        case 8:
                            Console.WriteLine("Exiting the application.");
                            break;

                        default:
                            Console.WriteLine("Invalid choice.");
                            break;
                    }

                } while (choice != 8);
            }


        
    }
}
