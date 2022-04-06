using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio18.Entities
{
    internal class BusinessAccount : Account
    {
        public int NumberOfEmployees { get; set; }

        public BusinessAccount() { }
        public BusinessAccount(string name, double anualAmount, int numberOfEmployees) : base(name, anualAmount)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Tax()
        {
            if(NumberOfEmployees > 10)
            {
                return AnualAmount * 0.14;
            }
            else
            {
                return AnualAmount * 0.16;
            }
        }
    }
}
