using System;

namespace Exercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            QuartosPousada[] vect = new QuartosPousada[10];

            Console.Write("Quantos quartos serão alugados? ");
            int x = int.Parse(Console.ReadLine());
            for (int i = 0; i < x; i++)
            {
                Console.WriteLine("\nAluguel #{0}: ", i+1);
                Console.Write("Nome: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto:  ");
                int room = int.Parse(Console.ReadLine());
                vect[room] = new QuartosPousada(name, email);
            }


            Console.WriteLine("\nQuartos ocupados:");
            for (int i = 0; i < vect.Length; i++)
            {
                if(vect[i] != null)
                {
                    Console.WriteLine(i + ": " + vect[i]);
                }
            }

        }
    }
}