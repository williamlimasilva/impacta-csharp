using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiniCaixaEletronico2.Data;

namespace MiniCaixaEletronico2.Business
{
    public class ContaService
    {
        private readonly ContaRepositorio _contaRepositorio = new ContaRepositorio();

        public decimal ConsultarSaldo()
        {
            // Obtém a conta do repositório
            var conta = _contaRepositorio.GetConta();
            // Retorna o saldo da conta
            return conta.Saldo;
        }

        public void Depositar(decimal valor)
        {
            // Obtém a conta do repositório
            var conta = _contaRepositorio.GetConta();
            // Realiza o depósito na conta
            conta.Depositar(valor);
        }

        public bool Sacar(decimal valor)
        {
            // Obtém a conta do repositório
            var conta = _contaRepositorio.GetConta();
            // Tenta realizar o saque na conta
            return conta.Sacar(valor);
        }
    }
}
