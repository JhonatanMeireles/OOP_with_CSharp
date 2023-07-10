namespace ConsoleOOP.Aula8_and_9.Entidades
{
    public class PessoaBase
    {
        public string Name { get; set; }

        protected DateTime? Hora { get; set; }

        public void ExibirNome() => Console.WriteLine(this.Name);
    }

    public class Cliente : PessoaBase 
    {
        public DateTime Cadastro { get; set; }

        public Cliente(string nome) 
        {
            this.Name = nome;
        }
    }

    public class Colaborador : Cliente 
    {
        public decimal Salario { get; set; }

        public Colaborador (string nome) : base(nome) 
        {
            this.Name = nome;
        }

    }
}
