// See https://aka.ms/new-console-template for more information

using ConsoleOOP.Aula10_and11.Entidades;

PessoaFisica pessoaFisica = new PessoaFisica(id: 1,nome: "Lucas",nroDocumento: "12345678912",rg: "987654");
/*
pessoaFisica.Id = 1;
pessoaFisica.Nome = "Lucas";
pessoaFisica.NroDocumento = "123456789";
pessoaFisica.RG = "987654";
*/
pessoaFisica.FormatarDocumento();

PessoaJuridica pessoaJuridica = new PessoaJuridica();
pessoaJuridica.Id = 2;
pessoaJuridica.Nome = "Lucas Colchões";
pessoaJuridica.NroDocumento = "12345678000112";
pessoaJuridica.InscricaoEstadual = "20202020";
pessoaJuridica.FormatarDocumento();


Console.WriteLine(pessoaFisica.ToString());
Console.WriteLine(pessoaFisica.ExibirDadosCompletos());
Console.WriteLine(pessoaJuridica.ExibirDadosCompletos());

DadosPessoaBase dadosPessoaBase = new PessoaFornecedor();

dadosPessoaBase.Id = 3;
dadosPessoaBase.Nome = "Microsoft";
dadosPessoaBase.NroDocumento = "12345678912345";
dadosPessoaBase.FormatarDocumento();

Console.WriteLine(dadosPessoaBase.ExibirDadosCompletos());

SaudacaoPessoa(pessoaFisica);



Console.ReadKey();

void SaudacaoPessoa(DadosPessoaBase pessoa)
{
    Console.WriteLine($"Bem vindo {pessoa.Nome}!");
}