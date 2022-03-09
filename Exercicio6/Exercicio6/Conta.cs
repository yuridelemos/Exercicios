using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio6
{
    internal class Conta
    {
        private int _numeroDaConta;
        private string _nome;
        public double ValorNaConta { get; private set; }

        public Conta() { }
        public Conta(int numeroConta, string nome)
        {
            _numeroDaConta = numeroConta;
            _nome = nome;
            ValorNaConta = 0.00;
        }
        public Conta(int numeroConta, string nome, double valorNaConta)
        {
            _numeroDaConta = numeroConta;
            _nome = nome;
            ValorNaConta = valorNaConta;
        }

        public int NumeroDaConta
        {
            get { return _numeroDaConta; }
            set
            {
                if (value.ToString() != "0000" && value.ToString().Length == 4)
                {
                    _numeroDaConta = (int)value;
                }
            }
        }

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.ToString().Length > 1)
                {
                    _nome = value;
                }
            }
        }

        public void AdicionarValor(double quantia)
        {
            ValorNaConta += quantia;
        }

        public void RemoverValor(double quantia)
        {
            ValorNaConta -= quantia + 5.00;
        }

        public override string ToString()
        {
            return "Conta " + _numeroDaConta + ", Titular: " + _nome + ", Saldo: $ " + ValorNaConta.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
