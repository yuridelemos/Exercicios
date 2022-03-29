using System;
using System.Globalization;
using Exercicio14.Entities;
using Exercicio14.Entities.Enums;

namespace Exercicio14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter cliente data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine(); 
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthday = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter order data:");
            DateTime dateNow = DateTime.Now;
            Console.Write("Status: ");
            OrderStatus statusOrder = Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.Write("How many items to this order? ");
            int o = int.Parse(Console.ReadLine());

            Client client = new Client(name, email, birthday);

            for(int i = 1; i <= o; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                name = Console.ReadLine();
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                OrderItem orderItem = new OrderItem(quantity, price, name);
            }
        }
    }
}