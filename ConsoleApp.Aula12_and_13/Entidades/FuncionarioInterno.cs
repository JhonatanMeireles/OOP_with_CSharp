namespace ConsoleApp.Aula12_and_13.Entidades
{
    public class FuncionarioInterno : Funcionario, ISalario
    {
        public string Cargo { get; set ; }

        public decimal AumentarSalario(decimal valorAumento)
        {
            return Salario += valorAumento;
        }

        public decimal ExibirSalario()
        {
            return this.Salario;
        }

        public decimal ReduzirSalario(decimal valorReducao)
        {
            throw new NotImplementedException();
        }
    }
}
