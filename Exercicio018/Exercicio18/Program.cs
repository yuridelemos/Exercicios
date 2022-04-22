using Exercicio18.Entities;
using System.Globalization;

namespace Exercicio18
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Account> accounts = new List<Account>();
            Console.Write("Enter the number of tax payers: ");
            int counter = int.Parse(Console.ReadLine());    
            for(int i = 1; i <= counter; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company: ");
                char TypeAccount = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string Name = Console.ReadLine();
                Console.Write("Anual Income: ");
                double Amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if(TypeAccount == 'i' || TypeAccount == 'I')
                {
                    Console.Write("Health expenditures: ");
                    double HealthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    accounts.Add(new IndividualAccount(Name, Amount, HealthExpenditures));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int NumberEmployeers = int.Parse(Console.ReadLine());
                    accounts.Add(new BusinessAccount(Name, Amount, NumberEmployeers));
                }
            }
            Console.WriteLine("\nTAXES PAID:");
            double sum = 0;
            foreach (Account account in accounts)
            {
                sum += account.Tax();
                Console.WriteLine($"{account.Name}: $ {account.Tax().ToString("F2", CultureInfo.InvariantCulture)}");
            }
            Console.WriteLine($"TOTAL TAXES: $ {sum.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}