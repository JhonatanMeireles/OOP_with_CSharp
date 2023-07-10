// See https://aka.ms/new-console-template for more information

using ConsoleApp.Aula12_and_13.Entidades;

FuncionarioExterno funcionario1 = new FuncionarioExterno();

funcionario1.Nome = "João";
funcionario1.Salario = 1000;
funcionario1.AumentarSalario(10);
//funcionario1.ReduzirSalario(10);

Console.WriteLine(funcionario1.Salario);

FuncionarioInterno funcionario2 = new();

funcionario2.Nome = "Maria";
funcionario2.Salario = 1000;
funcionario2.AumentarSalario(10);

Console.WriteLine(funcionario2.Salario);

ISalario funcionario3 = new FuncionarioExterno 
{ 
    Cargo = "T.I", 
    Nome = "Carlos", 
    Salario = 3000M 
};

funcionario3.AumentarSalario(10);

//Console.WriteLine(funcionario3.Cargo);
Console.WriteLine(funcionario3.ExibirSalario());

ISalario funcionario4 = new FuncionarioInterno
{
    Cargo = "T.I",
    Nome = "Carlos",
    Salario = 3000M
};
funcionario4.AumentarSalario(10);
//Console.WriteLine(funcionario3.Cargo);
Console.WriteLine(funcionario4.ExibirSalario());



Console.ReadKey();
