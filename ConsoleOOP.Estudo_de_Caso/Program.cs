// See https://aka.ms/new-console-template for more information
using ConsoleOOP.Estudo_de_Caso.Entidades;
using ConsoleOOP.Estudo_de_Caso.Servicos;

Console.WriteLine("Seja bem vindo ao programa \"Exibir Endereço\"");
Console.WriteLine("**********************************************");


Console.WriteLine("Escolha a ação abaixo:");
Console.WriteLine("(1) - Buscar Endereço:");
Console.WriteLine("(2) - Sair");

Console.WriteLine("Digite a opção desejada:");
var opcao = int.Parse(Console.ReadLine());

if (opcao == 1)
{
    Console.Write("Digite o CEP: ");
    var cep = Console.ReadLine();

    EnderecoServico enderecoServico = new EnderecoServico();
    enderecoServico.BuscarEndereco(cep);
    
    if (enderecoServico.ExisteCEP())
    {
        Endereco endereco = enderecoServico.MapearEndereco();

        Console.WriteLine(endereco.ToString());
    }
    else 
    {
        Console.WriteLine("CEP não encontrado");
    }
    
}

if (opcao == 2) 
{
    Environment.Exit(0);
}



Console.ReadKey();