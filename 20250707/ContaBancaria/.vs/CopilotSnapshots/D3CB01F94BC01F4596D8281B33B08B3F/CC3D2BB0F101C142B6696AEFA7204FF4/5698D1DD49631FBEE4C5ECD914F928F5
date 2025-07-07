using System;

namespace ContaBancaria
{
    public class ContaPoupanca : Conta
    {
        private double TaxaJuros { get; set; }

        public ContaPoupanca(int numero, string titular, double taxaJuros, double saldoInicial = 0.0)
            : base(numero, titular, saldoInicial)
        {
            TaxaJuros = taxaJuros;
        }

        public void AplicarJuros()
        {
            double juros = Saldo * TaxaJuros;
            Depositar(juros);
            Console.WriteLine($"Juros de R${juros:F2} aplicados com sucesso!");
        }

        public override void ExibirSaldo()
        {
            base.ExibirSaldo();
            Console.WriteLine($"Taxa de Juros: {TaxaJuros:P2}");
        }
    }
}
