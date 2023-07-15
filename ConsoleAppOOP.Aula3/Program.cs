// See https://aka.ms/new-console-template for more information
using ConsoleAppOOP.Aula3.Entidades;


NotaFiscal notaFiscal = new NotaFiscal();

Console.WriteLine(notaFiscal.Limite);

notaFiscal.Numero = 10;
Console.WriteLine(notaFiscal.Limite2);

Console.WriteLine($"Tipo de documento: {notaFiscal.TipoDocumento}");
Console.WriteLine($"Número do documento: {notaFiscal.Numero}");

Console.WriteLine(notaFiscal.Limite2);


Console.ReadKey();

