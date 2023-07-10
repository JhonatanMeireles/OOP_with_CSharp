namespace ConsoleOOP.Aula8_and_9.Entidades
{
    public partial class Pedido
    {
        public int NumeroNF { get; set; }

        public int SerieNF { get; set; }

        public void EmitirNotaFiscal() => Console.WriteLine($"Nota {NumeroNF}/{SerieNF} emitida.");
    }
}
