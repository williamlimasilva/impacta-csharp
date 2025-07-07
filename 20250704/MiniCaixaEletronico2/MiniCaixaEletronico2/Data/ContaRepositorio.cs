using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniCaixaEletronico2.Data
{
    public class ContaRepositorio
    {
        //emulação de uma conexão com um banco de dados _conta é o objeto de manipulação dos dados
        private static readonly Conta _conta = new Conta(123456, 1000.00m);

        public Conta GetConta()
        {
            //retorna a conta existente
            return _conta;
        }


    }
}
