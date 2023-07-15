using ContatoOOPExample;

namespace ConsoleOOP.Aula16_and_17.Extensions
{
    public static class ContatoExtensions
    {
        public static void EnviarEmail(this Contato contato)
        {
            Console.WriteLine($"Título: Envio de email por {contato.Nome} - ({contato.Email})");

        }

        public static  string ExibirNomeEmailFormatado (this Contato contato, bool formatoHML)
        {
            if (formatoHML)
            {
                return $"<h1>{contato.Nome} - {contato.Email}</h1>";

            }

            return $"{contato.Nome} - {contato.Email}";
        }
    }
}
