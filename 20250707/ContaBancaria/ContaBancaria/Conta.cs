using System;

namespace ContaBancaria
{
    public class Conta
    {
        public int Numero { get; protected set; }
        public string Titular { get; protected set; }
        protected double Saldo { get; set; }

        public Conta(int numero, string titular, double saldoInicial = 0.0)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldoInicial;
        }

        public virtual void Depositar(double valor)
        {
            if (valor > 0)
            {
                Saldo += valor;
                Console.WriteLine($"Depósito de R${valor:F2} realizado com sucesso. Novo saldo: R${Saldo:F2}");
            }
            else
            {
                Console.WriteLine("Valor de depósito inválido");
            }
        }

        public virtual bool Sacar(double valor)
        {
            if (valor <= 0)
            {
                throw new ArgumentException("Valor de saque deve ser maior que zero.");
            }

            if (Saldo < valor)
            {
                throw new SaldoInsuficienteException();
            }

            Saldo -= valor;
            Console.WriteLine($"Saque de R${valor:F2} realizado com sucesso. Novo saldo: R${Saldo:F2}");
            return true;
        }

        public virtual void ExibirSaldo()
        {
            Console.WriteLine($"Conta: {Numero} - Titular: {Titular} - Saldo: R${Saldo:F2}");
        }
    }
}
