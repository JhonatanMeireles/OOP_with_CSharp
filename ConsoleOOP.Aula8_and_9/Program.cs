using ConsoleOOP.Aula8_and_9.Entidades;
using ConsoleOOP.Aula8_and_9.TiposDeClasses;

PessoaBase pessoaBase = new PessoaBase();
pessoaBase.Name = "José";

pessoaBase.ExibirNome();

Cliente cliente = new("Ana");
cliente.Cadastro = DateTime.Now;
cliente.ExibirNome();
Console.WriteLine(cliente.Cadastro.ToString());

Colaborador colaborador = new(nome: "Josefa");
colaborador.Salario = 5000;

colaborador.ExibirNome();


Pedido pedido = new Pedido();
pedido.Nome = "Pipoca";
pedido.Endereco = "Rua F,5000";
pedido.NumeroNF = 123;
pedido.SerieNF = 1;

pedido.EmitirNotaFiscal();
pedido.ExibirDestinatario();

var totalNome = TratamentoTexto.TotalString(pedido.Nome);

Console.WriteLine(totalNome);
Console.WriteLine(TratamentoTexto.Maiusculo(pedido.Nome));

Contato contato = new(nome: "Nome da primeira pessoa");

Console.WriteLine(contato.Nome);
Console.WriteLine(contato.Contador);
Console.WriteLine(Contato.TotalContatos);

Contato contato2 = new(nome: "Nome da segunda pessoa");

Console.WriteLine(contato2.Nome);
Console.WriteLine(contato2.Contador);
Console.WriteLine(Contato.TotalContatos);

PessoaFisica pessoaFisica = new();
pessoaFisica.Nome = "";

try
{
    ValidacaoPessoaFisica validacaoPessoaFisica = new(pessoaFisica);
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message); 
}


Console.WriteLine("Passou no teste");

Contato.ExibirMensagem();

Console.ReadKey();