using ClassLibraryExemploClasse.Entidades;
using ConsoleOOP.Aula4_and_5.Construtor;
using ConsoleOOP.Aula4_and_5.ModificadoresDeAcesso;

namespace ConsoleOOP.Aula4_and_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cargo = new Cargo();

            var departamento = new Departamento();

            departamento.Descricao = "Programação";

            departamento.EscreverCnae("Teste");

            departamento.ExibirCnae();

            departamento.SetarSalario(5800);

            departamento.ExibirSalario();

            Console.WriteLine(departamento.Descricao);

            Console.WriteLine("**************Construtores**************");

            Carro carro1 = new Carro();

            carro1.Marca = "Fiat";
            carro1.Modelo = "Castback Limited Edition by Abarth T270 AT6";
            carro1.Ano = 2023;
            carro1.Cor = "Preto";
            carro1.Valor = 159_990M;

            Carro carro2 = new ();

            carro2.Marca = "BMW";
            carro2.Modelo = "320i";
            carro2.Ano = 2023;
            carro2.Cor = "Cinza";
            carro2.Valor = 355_950M;


            Console.WriteLine(carro2.Marca);

            try
            {
                Carro carro3 = new Carro("Chevrolet", "Onix", "Grafite", 2013, 38_900M);
                Console.WriteLine(carro3.Modelo);
            }
            catch(Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }

            


            Contato contato = new Contato("Bernardo", "Bernardo@email.com.br");

            Console.WriteLine(contato.Email);

            contato.AlterarNome("Érika");

            Console.WriteLine(contato.Nome);


            Contato contato1 = new Contato(DateTime.Now,"Bernardo","");

            Funcionario funcionario = new Funcionario("Thaina", "PO", 10000, "Contratar");

            //Console.WriteLine("Hello, World!");
        }
    }
}