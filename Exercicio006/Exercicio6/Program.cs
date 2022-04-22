using System;
using System.Globalization;

namespace Exercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conta conta;
            Console.Write("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string nome = Console.ReadLine();
            Console.Write("Haverá depósito inicial? (s/n): ");
            char opcao = char.Parse(Console.ReadLine());
            if (opcao == 's' || opcao == 'S')
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new Conta(numero, nome, valor);
            }
            else
            {
                conta = new Conta(numero, nome);
            }
            Console.WriteLine("\nDados da conta:");
            Console.WriteLine(conta);

            Console.Write("Entre um valor para depósito: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); ;
            conta.AdicionarValor(quantia);
            Console.WriteLine("\nDados da conta atualizados:");
            Console.WriteLine(conta);

            Console.Write("\nEntre um valor para saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.RemoverValor(quantia);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);
        }
    }
}