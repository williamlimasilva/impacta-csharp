using System;

namespace ContaBancaria
{
    public class ContaCorrente : Conta
    {
        private double LimiteChequeEspecial { get; set; }

        public ContaCorrente(int numero, string titular, double limiteChequeEspecial, double saldoInicial = 0.0)
            : base(numero, titular, saldoInicial)
        {
            LimiteChequeEspecial = limiteChequeEspecial;
        }

        public override bool Sacar(double valor)
        {
            if (valor > 0 && (Saldo + LimiteChequeEspecial) >= valor)
            {
                Saldo -= valor;
                Console.WriteLine($"Saque de R${valor:F2} realizado com sucesso. Novo saldo: R${Saldo:F2}");
                if (Saldo < 0)
                {
                    Console.WriteLine($"Atenção: Utilizando cheque especial. Limite disponível: R${(LimiteChequeEspecial + Saldo):F2}");
                }
                return true;
            }
            Console.WriteLine("Saldo e limite insuficientes ou valor inválido para saque");
            return false;
        }

        public override void ExibirSaldo()
        {
            base.ExibirSaldo();
            Console.WriteLine($"Limite de Cheque Especial: R${LimiteChequeEspecial:F2}");
        }
    }
}
