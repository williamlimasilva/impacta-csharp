using System;

namespace ContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Demonstração do Sistema Bancário ===\n");


            /*List<Conta> contas = new List<Conta>();
            contas.Add(new ContaCorrente(1001, "João Silva", 1000.0, 500.0));
            contas.Add(new ContaPoupanca(2001, "Maria Santos", 0.01, 1000.0));
            contas.Add(new ContaCorrente(1002, "Carlos Souza", 1500.0, 300.0));

            double saque = 200.0;

            foreach (Conta conta in contas)
            {
                conta.ExibirSaldo();
                Console.WriteLine();
                if (conta.Sacar(saque))
                {
                    Console.WriteLine($"Saque de R${saque:F2} realizado com sucesso na conta {conta.Numero}.");
                }
                else
                {
                    Console.WriteLine($"Falha ao realizar saque de R${saque:F2} na conta {conta.Numero}.");
                }
                conta.ExibirSaldo();
                Console.WriteLine();
            }*/

            /*ContaCorrente contaCorrente = new ContaCorrente(1001, "João Silva", 500.0, 1000.0);
            ContaPoupanca contaPoupanca = new ContaPoupanca(2001, "Maria Santos", 0.01, 1000.0);

            var seguro = new SeguroDeVida();

            List<ITributavel> tributaveis = new List<ITributavel>();
            tributaveis.Add(contaCorrente);
            tributaveis.Add(seguro);
            //tributaveis.Add(contaPoupanca);

            Console.WriteLine("Calculando impostos sobre os tributáveis...\n");
            double totalImposto = 0.0;
            foreach (var item in tributaveis)
            {
                double imposto = item.CalcularImposto();
                totalImposto += imposto;
                Console.WriteLine($"Imposto calculado: R${imposto:F2}");
            }
            Console.WriteLine($"\nTotal de impostos: R${totalImposto:F2}\n");
            */

            ContaCorrente contaThowNewException = new ContaCorrente(1001, "João Silva", 500.0, 1000.0);
            contaThowNewException.Sacar(2000.0); // Isso deve lançar uma exceção de SaldoInsuficienteException

        }
    }
}

