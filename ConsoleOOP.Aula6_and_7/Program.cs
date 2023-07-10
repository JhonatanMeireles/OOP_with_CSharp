// See https://aka.ms/new-console-template for more information
using ClassLibraryExemploClasse.Entidades;
using ConsoleOOP.Aula6_and_7.Metodos;

Console.WriteLine("Hello, World!");

Funcionario funcionario = new Funcionario(nome: "Weverton", cargo: "Garçom", salario: 100M, acao: "Contratar");

//funcionario.Salario = funcionario.Salario * 1.1M ;

funcionario.AumentarSalario(60M);
Console.WriteLine(funcionario.ExibirSalario());
funcionario.AumentarSalario(salarioPercentual: 50d);
Console.WriteLine(funcionario.ExibirSalario());

funcionario.DiminuirSalario(10M);
Console.WriteLine(funcionario.ExibirSalario());

funcionario.DiminuirSalario(200M);
Console.WriteLine(funcionario.ExibirSalario());

Console.ReadKey();
