using ECommerceBackend.Helpers;
using ECommerceBackend.Interfaces;
using ECommerceBackend.Models;
using ECommerceBackend.Services;
namespace ECommerceBackend
{
    
    internal  class Program
    {

        
        
            static async Task Main(string[] args)
            {
                var productService = new ProductService();
                var inputHelper = new InputHelper();
                var EmailService = new HelpsServices(new EmailService());
                var SmsService = new HelpsServices(new SmsService());

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
                        "7. Send Email Message\n" +
                        "8. Send SMS Message\n" +
                        "9. Exit"
                    );

                    choice = inputHelper.ReadInt();

                    switch (choice)
                    {
                        case 1:
                        Console.WriteLine(
                            "Enter 1 for Add Food Product\n"+
                            "Enter 2 for Add Electronic Product");
                            int type = inputHelper.ReadInt();
                            Console.WriteLine("Enter Product Id:");
                            int id = inputHelper.ReadInt();

                            Console.WriteLine("Enter Product Name:");
                            string name = inputHelper.ReadString();

                            Console.WriteLine("Enter Product Price:");
                            decimal price = inputHelper.ReadDecimal();

                            Console.WriteLine("Enter Product Stock:");
                            int stock = inputHelper.ReadInt();
                        if(type == 1)
                        {
                            Console.WriteLine("Enter Product Expiration Date (yy-MM-dd)");
                            DateTime expirationDate = inputHelper.ReadDate();
                            var foodproduct = new FoodProduct(
                                id,
                                name,
                                price,
                                stock,
                                expirationDate
                            );
                            productService.AddProduct(foodproduct);
                        }
                        else if (type == 2)
                        {
                            ElectronicProduct electronicproduct = new ElectronicProduct(
                                id,
                                name,
                                price,
                                stock
                            );
                            productService.AddProduct(electronicproduct);
                        }
                        else
                        {
                            Console.WriteLine("Invalid product type.");

                        }
                            break;

                        case 2:
                            Console.WriteLine("Enter Product Id:");
                            id = inputHelper.ReadInt();

                            productService.RemoveProductById(id);
                            break;

                        case 3:
                        Console.WriteLine("Enter 1 for Update Food Product\n" + "Enter 2 for Update Electronic Product");
                        int type1 = inputHelper.ReadInt();
                        Console.WriteLine("Enter Product Id you want to update:");
                            id = inputHelper.ReadInt();

                            Console.WriteLine("Enter new Product Name:");
                            name = inputHelper.ReadString();

                            Console.WriteLine("Enter new Product Price:");
                            price = inputHelper.ReadDecimal();

                            Console.WriteLine("Enter new Product Stock:");
                            stock = inputHelper.ReadInt();
                        if(type1 == 1)
                        {
                            Console.WriteLine("Enter new Product Expiration Date (yyyy-MM-dd):");
                            DateTime expirationDate = inputHelper.ReadDate();
                             var foodproduct = new FoodProduct(
                                id,
                                name,
                                price,
                                stock,
                                expirationDate
                            );
                            productService.UpdateProduct(foodproduct);
                        }
                        else if(type1 == 2)
                        {
                            var electronicproduct = new ElectronicProduct(
                                id,
                                name,
                                price,
                                stock
                            );
                            productService.UpdateProduct(electronicproduct);

                        }
                        else
                        
                            Console.WriteLine("Invalid product type.");

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

                            productService.SearchByName(product => product.Name==name);
                            break;

                        case 7:
                            Console.WriteLine("Enter Help Message:");
                            string EmailMessage = inputHelper.ReadString();
                           
                            await EmailService.SendHelpMessage(EmailMessage);
                            break;
                    case 8:
                        Console.WriteLine("Enter Help Message:");
                        string SmsMessage = inputHelper.ReadString();

                        await SmsService.SendHelpMessage(SmsMessage);
                        break;
                    case 9:
                            Console.WriteLine("Exiting the application.");
                            break;

                        default:
                            Console.WriteLine("Invalid choice.");
                            break;
                    }

                } while (choice != 9);
            }


        
    }
}
