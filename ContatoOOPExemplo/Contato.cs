namespace ConsoleOOP.Aula16_and_17.Entidades
{
    public class Contato
    {
        public string? Nome { get; set; }
        public string? Email { get; set; }        
        public string? Telefone { get; set; }
        public string? Celular { get; set; }
        public string? WhatsApp { get; set; }
        public string? RedeSocial { get; set; }

        public void ExibirContatoCompleto()
        {
            IEnumerable<string> listaParteTexto = new[]
            {
                $"Nome : {Nome}",
                $"Email : {Email}",
                $"Telefone : {Telefone}",
                $"Celular : {Celular}",
                $"WhatsApp : {WhatsApp}",
                $"RedeSocial : {RedeSocial}"

            };

            Console.WriteLine($"{string.Join(" | ", listaParteTexto)}");
        }

    }
}
