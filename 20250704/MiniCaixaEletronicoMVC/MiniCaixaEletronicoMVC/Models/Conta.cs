using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniCaixaEletronicoMVC.Models
{
    public class Conta
    {
        public decimal Saldo { get; set; }
        public Conta(decimal saldoInicial)
        {
            Saldo = saldoInicial;
        }

        public void Depositar(decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor do depósito deve ser maior que zero.");
            }
            Saldo += valor;
        }

        public bool Sacar(decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor do saque deve ser maior que zero.");
                return false;
            }
            if (valor > Saldo)
            {
                Console.WriteLine("Saldo insuficiente para realizar o saque.");
                return false;
            }
            Saldo -= valor;
            return true;
        }
    }
}
