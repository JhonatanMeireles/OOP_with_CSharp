namespace ConsoleOOP.Aula6_and_7.Metodos
{
    public class Contato
    {
        public String Name { get; private set; }

        public int Age { get; private set; }

        public String Email { get; private set; }
        public Contato(String nome, int idade, string email)
        {
            this.Name = nome;
            this.Age = idade;
            Email = email;
        }
    }
}
