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
WhatsApp = "(21) 99191-9191",
};

//contato.ExibirContatoCompletoConsole();

contato.EnviarEmail();
Console.WriteLine(contato.ExibirNomeEmailFormatado(true));

Console.ReadKey();