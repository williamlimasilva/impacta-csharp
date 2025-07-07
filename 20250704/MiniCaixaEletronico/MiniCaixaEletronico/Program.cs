namespace MiniCaixaEletronico
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal saldo = 1500.78m; // m no final indica que é um decimal
            bool continuar = true;

            while (continuar) {
                Console.WriteLine("Bem-vindo ao Mini Caixa Eletrônico!");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("Saldo Inicial: R$ " + saldo.ToString("C")); //moeda local
                Console.WriteLine("Selecione uma opção:");
                Console.WriteLine("1 - Ver Saldo Detalhado");
                Console.WriteLine("2 - Depositar");
                Console.WriteLine("3 - Realizar Saque");
                Console.WriteLine("4 - Sair");
                Console.Write("Opção: ");
                string opcao = Console.ReadLine();
                if(opcao == "4") { 
                    continuar = false;
                    Console.WriteLine("Obrigado por usar o Mini Caixa Eletrônico!");
                    continue;
                }
                Console.Clear();
            }
        }
    }
}
