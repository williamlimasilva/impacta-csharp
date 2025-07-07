using MiniCaixaEletronico2.Business;

bool continuar = true;
var contaService = new ContaService();
while (continuar)
{
    Console.WriteLine("Bem-vindo ao Mini Caixa Eletrônico!");
    Console.WriteLine("--------------------------------");
    Console.WriteLine("Saldo Inicial: R$ " + contaService.ConsultarSaldo().ToString("F2"));
    Console.WriteLine("Selecione uma opção:");
    Console.WriteLine("1 - Ver Saldo Detalhado");
    Console.WriteLine("2 - Depositar");
    Console.WriteLine("3 - Realizar Saque");
    Console.WriteLine("4 - Sair");
    Console.Write("Opção: ");
    string opcao = Console.ReadLine();
    if (opcao == "4")
    {
        continuar = false;
        Console.WriteLine("Obrigado por usar o Mini Caixa Eletrônico!");
        continue;
    }
    Console.Clear();
}
Console.WriteLine("Até Mais...");