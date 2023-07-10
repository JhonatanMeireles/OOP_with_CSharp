namespace ConsoleOOP.Aula8_and_9.Entidades
{
    public partial class Pedido
    {
        public string Nome { get; set; }

        public string Endereco { get; set; }

        public void ExibirDestinatario() => Console.WriteLine($"Pedido de {Nome} despachado.");
    }
}
