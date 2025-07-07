using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiniCaixaEletronicoMVC.Models;
using MiniCaixaEletronicoMVC.Views;


namespace MiniCaixaEletronicoMVC.Controllers
{
    public class ContaController
    {
        private readonly Conta _conta; 
        private readonly ContaView _view;

        public ContaController()
        {
            _conta = new Conta(3000);
            _view = new ContaView(); 
        }

        public void Iniciar()
        {
            bool continuar = true;

            while (continuar)
            {
                string opcao = _view.ObterOpcaoMenu(_conta.Saldo);

                switch (opcao)
                {
                    case "1":
                        _view.ExibirMensagem($"Seu saldo atual é: {_conta.Saldo:C}"); 
                        _view.PausarVoltarAoMenu(); 
                        break;
                    case "2":
                        decimal valorDeposito = _view.SolicitarValor("Digite o valor do depósito: "); 
                        _conta.Depositar(valorDeposito); 
                        _view.ExibirMensagem($"Depósito de {valorDeposito:C} realizado com sucesso!"); 
                        _view.PausarVoltarAoMenu(); 
                        break;
                    case "3":
                        decimal valorSaque = _view.SolicitarValor("Digite o valor do saque: "); 
                        if (_conta.Sacar(valorSaque)) 
                        {
                            _view.ExibirMensagem($"Saque de {valorSaque:C} realizado com sucesso!"); 
                        }
                        _view.PausarVoltarAoMenu(); 
                        break;
                    case "4":
                        continuar = false;                        
                        break;
                    default:
                        _view.ExibirMensagem("Opção inválida. Tente novamente."); 
                        _view.PausarVoltarAoMenu(); 
                        break;
                }
            }
            Console.WriteLine("Obrigado por usar o Banco CSharp S.A. -- MVC -- Até logo!");
        }
    }
}
