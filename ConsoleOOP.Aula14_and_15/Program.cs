// See https://aka.ms/new-console-template for more information
using ConsoleOOP.Aula14_and_15.Entidades;

Console.WriteLine("Hello, World!");

/*
void AdicionarTexto(List<string> Lista, string texto)
{
    Lista.Add(texto);
}

void AdicionarNumero(List<int> Lista, int valor)
{
    Lista.Add(valor);
}

void AdicionarBooleano(List<bool> Lista, bool ver)
{
    Lista.Add(ver);
}
*/

void Adiciona<T>(List<T> Lista, T valor)
{
    Lista.Add(valor);
}

List<string> listaTexto = new List<string>();
Adiciona<string>(listaTexto, "Novo Valor");

List<int> listaNumeros = new List<int>();
Adiciona<int>(listaNumeros, 0);
Adiciona<int>(listaNumeros, 1);


void EntrarQualquerCoisa<T>(T coisa)
{
    Console.WriteLine(coisa);
}


EntrarQualquerCoisa(10);
EntrarQualquerCoisa("Pipoca");
EntrarQualquerCoisa(true);

Anotacoes<string> anotacoesTexto = new Anotacoes<string>();
anotacoesTexto.ListaItens.Add("Texto 1");
anotacoesTexto.ListaItens.Add("Texto 2");
anotacoesTexto.ListaItens.Add("Texto 3");

anotacoesTexto.ExibirItens();


Anotacoes<int> anotacoesNumber =  new Anotacoes<int>();

anotacoesNumber.ListaItens.Add(1);
anotacoesNumber.ListaItens.Add(2);
anotacoesNumber.ListaItens.Add(3);

anotacoesNumber.ExibirItens();


AnotacoesVersao2<string> anotacoesVersao2 = new();

anotacoesVersao2.AdicionarItens("Mais texto 1");
anotacoesVersao2.AdicionarItens("Mais texto 2");
anotacoesVersao2.AdicionarItens("Mais texto 3");

foreach(string item in anotacoesVersao2.ListaItens)
{
    Console.WriteLine(item);
}


AnotacoesVersao3<int, string> anotacoesIntString = new(1000, "Tipo String");

int codigo = anotacoesIntString.RetornarCodigo();
Console.WriteLine($"Retorno código {codigo}");


TarefaDiaria tarefaDiaria1 = new TarefaDiaria() { Titulo = "Minha manhã", Descricao = "Caminhar"};
TarefaDiaria tarefaDiaria2 = new TarefaDiaria() { Titulo = "Minha trade", Descricao = "trabalhar" };
TarefaDiaria tarefaDiaria3 = new TarefaDiaria() { Titulo = "Minha noite", Descricao = "Estudar" };



AnotacoesVersao4<TarefaDiaria> anotacaoTarefaDiaria = new();

anotacaoTarefaDiaria.AdicionarTarefa(tarefaDiaria1);
anotacaoTarefaDiaria.AdicionarTarefa(tarefaDiaria2);
anotacaoTarefaDiaria.AdicionarTarefa(tarefaDiaria3);

Console.WriteLine($"Total tarefa {anotacaoTarefaDiaria.ListaTarefa.Count}");

foreach (TarefaDiaria item in anotacaoTarefaDiaria.ListaTarefa)
{
    Console.WriteLine($"Titulo: {item.Titulo} - Descricao: {item.Descricao}");
}

TarefaDiariaAnalitica tarefaDiariaAnalitica1 = new TarefaDiariaAnalitica() { Titulo = "Minha manhã", Descricao = "Caminhar" };
TarefaDiariaAnalitica tarefaDiariaAnalitica2 = new TarefaDiariaAnalitica() { Titulo = "Minha trade", Descricao = "trabalhar" };
TarefaDiariaAnalitica tarefaDiariaAnalitica3 = new TarefaDiariaAnalitica() { Titulo = "Minha noite", Descricao = "Estudar" };



AnotacoesVersao4<TarefaDiariaAnalitica> anotacaoTarefaDiariaAnalitica = new();

anotacaoTarefaDiariaAnalitica.AdicionarTarefa(tarefaDiariaAnalitica1);
anotacaoTarefaDiariaAnalitica.AdicionarTarefa(tarefaDiariaAnalitica2);
anotacaoTarefaDiariaAnalitica.AdicionarTarefa(tarefaDiariaAnalitica3);

anotacaoTarefaDiariaAnalitica.RemoverTarefa(tarefaDiariaAnalitica3);


Console.WriteLine($"Total tarefa {anotacaoTarefaDiariaAnalitica.ListaTarefa.Count}");

foreach (TarefaDiariaAnalitica item in anotacaoTarefaDiariaAnalitica.ListaTarefa)
{
    Console.WriteLine($"Titulo: {item.Titulo} - Descricao: {item.Descricao}");
}


Console.ReadKey();