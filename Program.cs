List<double> operacoes = new List<double>();
string opcao;
do
{
    Console.WriteLine("------------------Bem vindo ao Banco Nacional de Coqueiros BNC-------------------");
    Console.WriteLine(" Selecione uma opção para continuar:");
    Console.WriteLine("1 - Adicionar transação");
    Console.WriteLine("2 - Consultar extrato");
    Console.WriteLine("3 - Sair");

    opcao = Console.ReadLine();

    if (opcao == "1")
    {
        Console.WriteLine("Digite o valor da operação em R$:");
        double valor = (double.Parse(Console.ReadLine()));
        operacoes.Add(valor);
    }
    else if (opcao == "2")
    {
        Console.WriteLine("Extrato de transações:");
        double saldo = 0;
        foreach (double din in operacoes)
        {
            saldo += din;
            Console.WriteLine($"       R$ {din.ToString("F2")}");
        };
        Console.WriteLine($"Seu saldo é de R$ {saldo.ToString("F2")}");
    }
    else
    {
        Console.WriteLine("Volte sempre! Obrigado por usar o BNC!");
    }
}
while (!(opcao == "3"));
