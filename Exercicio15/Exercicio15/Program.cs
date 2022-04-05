using System;
using System.Globalization;
using Exercicio15.Entities;

namespace Exercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            Console.Write("Enter the number of employees: ");
            int count = int.Parse(Console.ReadLine());
            for(int i = 1; i <= count; i++)
            {
                Console.WriteLine($"Employee #{i} data:");
                Console.Write("Outsourced (y/n)? ");
                char resp = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double ValueHours = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (resp == 'y' || resp == 'Y')
                {
                    Console.Write("Additional charge: ");
                    double Additional = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    employees.Add(new OutsourcedEmployee(name, hours, ValueHours, Additional));
                }
                else
                    employees.Add(new Employee(name,hours,ValueHours));
            }
            Console.WriteLine("\nPAYMENTS: ");
            foreach(Employee employee in employees)
            {
                Console.WriteLine($"{employee.Name} - $ {employee.Payment().ToString("F2", CultureInfo.InvariantCulture)}");
            }

        }
    }
}