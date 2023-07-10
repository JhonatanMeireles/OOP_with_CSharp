// See https://aka.ms/new-console-template for more information
using ConsoleOOP.Aula6_and_7.Metodos;

Console.WriteLine("Hello, World!");

Funcionario funcionario = new Funcionario(nome: "Weverton", cargo: "Garçom",salario: 100M, acao: "Contratar" );

//funcionario.Salario = funcionario.Salario * 1.1M ;

Console.WriteLine(funcionario.Salario);

Console.ReadKey();
