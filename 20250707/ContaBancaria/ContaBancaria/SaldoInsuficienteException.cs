using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria
{
    internal class SaldoInsuficienteException : Exception
    {
        public SaldoInsuficienteException()
            : base("Saldo insuficiente para realizar a operação.")
        {
        }
        public SaldoInsuficienteException(string message)
            : base(message)
        {
        }
        public SaldoInsuficienteException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
