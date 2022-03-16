using System;

namespace Exercicio9
{
    public class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int contador = 0;

            int[,] matriz = new int[x, x];
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < x; j++)
                {
                    matriz[i, j] = int.Parse(values[j]);
                }
            }

            Console.WriteLine("\nMain diagonal: ");

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                 for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (i == j)
                        Console.Write(matriz[i, j] + " ");
                    if (matriz[i, j] < 0)
                        contador++;
                }
            }
            Console.WriteLine("\nNegative numbers = " + contador);
        }
    }
}