using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniCaixaEletronico2.Data
{
    public class Conta
    {
        public int NumeroConta { get; set; }
        public decimal Saldo { get; set; }

        public Conta(int numeroConta, decimal saldoInicial)
        {
            NumeroConta = numeroConta;
            Saldo = saldoInicial;
        }

        public void Depositar(decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor do depósito deve ser maior que zero.");
            }
            else
            {
                Saldo += valor;
            }
        }

        public bool Sacar(decimal valor)
        {
            if (valor <= 0)
            {
               Console.WriteLine("O valor do saque deve ser maior que zero.");
                return false;
            }
            else if (valor > Saldo)
            {
                Console.WriteLine("Saldo insuficiente para realizar o saque.");
                return false;
            }
            else
            {
                Saldo -= valor;
                return true;
            }
        }
    }
}
