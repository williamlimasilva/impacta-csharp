using System;

namespace ContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Demonstração do Sistema Bancário ===\n");

            // Criando uma conta corrente
            var contaCorrente = new ContaCorrente(1001, "João Silva", 1000.0, 500.0);
            Console.WriteLine("Conta Corrente criada:");
            contaCorrente.ExibirSaldo();

            Console.WriteLine("\nRealizando operações na Conta Corrente:");
            contaCorrente.Depositar(1000.0);
            contaCorrente.Sacar(1200.0);
            contaCorrente.ExibirSaldo();

            Console.WriteLine("\n----------------------------------------\n");

            // Criando uma conta poupança
            var contaPoupanca = new ContaPoupanca(2001, "Maria Santos", 0.01, 1000.0);
            Console.WriteLine("Conta Poupança criada:");
            contaPoupanca.ExibirSaldo();

            Console.WriteLine("\nRealizando operações na Conta Poupança:");
            contaPoupanca.Depositar(500.0);
            contaPoupanca.AplicarJuros();
            contaPoupanca.ExibirSaldo();
        }
    }
}

