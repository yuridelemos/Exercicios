﻿using System;
using System.Collections.Generic;
using System.Globalization;


namespace Exercicio8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();

            Console.Write("How many employees will be registered? ");
            int collector = int.Parse(Console.ReadLine());
            for (int i = 0; i < collector; i++)
            {
                Console.WriteLine("Emplyoee #{0}", i + 1);
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Employee(id, name, salary));
                Console.WriteLine();
            }
            Console.Write("Enter the employee id that will have salary increase : ");
            collector = int.Parse(Console.ReadLine());

            Employee employee = list.Find(x => x.Id == collector);
            if (employee != null)
            {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                employee.IncreaseSalary(percentage);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }
            Console.WriteLine("Updated list of employees:");
            foreach (Employee x in list)
            {
                Console.WriteLine(x);
            }

        }
    }
}