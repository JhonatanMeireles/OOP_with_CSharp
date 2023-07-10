namespace ConsoleOOP.Aula4_and_5.ModificadoresDeAcesso
{
    public class Cargo
    {
        public string? Descricao { get; set; }

        protected string? Cnae { get; set; }

        private decimal Salario { get; set; }

        public decimal Salario2 { get; private set; }

        public decimal Salario3 { get; set; }


        public void SetarSalario (decimal salario)
        {
            this.Salario = salario;
        }

        public void ExibirSalario()
        {
            Console.WriteLine(this.Salario);
        }

    }

    public class Departamento : Cargo
    {
        public void EscreverCnae(string? cnae)
        {
            this.Cnae = cnae;
        }
        public void ExibirCnae()
        { 
            Console.WriteLine(this.Cnae); 
        }
    }
}
