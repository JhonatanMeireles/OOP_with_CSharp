namespace ConsoleOOP.Aula6_and_7.Metodos
{
    public class Funcionario
    {
        public string? Nome { get; set; }

        public string? Cargo { get; set; }

        public decimal? Salario { get; set; }

        public Funcionario() { }

        public Funcionario(string nome, string cargo, decimal? salario)
        {
            Nome = nome;
            Cargo = cargo;
            Salario = salario;
        }

        public Funcionario
            (string nome,
            string cargo,
            decimal salario,
            string acao
            ) : this(nome, cargo, salario)
        {

            if (acao == "Contratar")
                Console.WriteLine($"Contratação Feita de {this.Nome}");
        }
    }
}
