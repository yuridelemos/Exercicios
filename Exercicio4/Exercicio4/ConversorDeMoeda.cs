using System.Globalization;

namespace Exercicio4
{
    internal class ConversorDeMoeda
    {
        public static double IOF = 1.06;
        
        public static double ConversorRealDolar(double cotacao, double quantidade)
        {
            return quantidade * cotacao * IOF;
        }

    }
}
