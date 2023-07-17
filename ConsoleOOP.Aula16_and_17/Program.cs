using ConsoleOOP.Aula16_and_17;
using ConsoleOOP.Aula16_and_17.Extensions;
using ContatoOOPExample;

Contato contato = new() 
{ 
Nome = "Bernardo",
Celular = "(21) 99191-9191",
Email = "BBB@gmail.com",
RedeSocial =  "Instagram",
Telefone = "(21) 99191-9191",
WhatsApp = "(21) 9  9 191 -91 91",
};

contato.Nome = contato.Nome.Maiusculo();
contato.Email = contato.Email.Minusculo();
contato.WhatsApp = contato.WhatsApp.RemoverEspaco();
contato.ExibirContatoCompletoConsole();

/*
contato.EnviarEmail();
Console.WriteLine(contato.ExibirNomeEmailFormatado(true));
*/

string numero1 = "1000,00";
string numero2 = "2000.00";

Console.WriteLine(numero1 + numero2);
Console.WriteLine(numero1.ConverteParaDecimal() + numero2.ConverteParaDecimal());


Console.ReadKey();


