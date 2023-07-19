// See https://aka.ms/new-console-template for more information

using ConsoleOOP.Aula18_and_19.Enumeradores;

do
{
    Console.Clear();

    Console.WriteLine("Escolha a opção abaixo:");
    Console.WriteLine("(1) Salvar ");
    Console.WriteLine("(2) Listar ");
    Console.WriteLine("(3) Excluir ");
    Console.WriteLine("(4) Sair ");
    Console.WriteLine(" ");
    Console.WriteLine("Digite sua opção:");
    var opcao = (OpcaoSistemaEnum) int.Parse(Console.ReadLine()!);

    if (opcao == OpcaoSistemaEnum.Salvar)
    {
        Console.WriteLine("Opção Salvar");
    }
    else if (opcao == OpcaoSistemaEnum.Listar)
    {
        Console.WriteLine("Opção Listar");
    }
    else if (opcao == OpcaoSistemaEnum.Sair)
    {
        Console.WriteLine("Opção Sair");
        Console.ReadKey();
        Environment.Exit(0);
    }
    else if (opcao == OpcaoSistemaEnum.Excluir)
    {
        Console.WriteLine("Opção Excluir");
    }

    Console.ReadKey();

} while (true);
Console.ReadKey();
