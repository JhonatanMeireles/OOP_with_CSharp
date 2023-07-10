namespace ConsoleOOP.Aula4_and_5.Construtor
{
    public class Contato
    {
        public String? Nome { get; private set; }

        public String? Email { get; private set; }

        public DateTime Criacao { get; private set; }


        public Contato(String? nome, String? email) 
        {
            this.Nome = nome;
            this.Email = email;
        }
        
        public Contato(String? nome)
        {
            this.Nome = nome;
        }

        public Contato(DateTime criacao, string nome, string email) : this(nome, email)
        {
            this.Criacao = criacao;
            Console.WriteLine($"Nome: {this.Nome} - Email: {this.Email} - Data: {this.Criacao:dd/MM/yyyy}");
        }

        public void AlterarNome(String nome)
        { 
            this.Nome = nome; 
        }
        public void AlterarEmail(String email) => this.Email = email;
    }
}
