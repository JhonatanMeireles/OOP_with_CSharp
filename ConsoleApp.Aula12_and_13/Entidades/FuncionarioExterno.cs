namespace ConsoleApp.Aula12_and_13.Entidades
{
    public class FuncionarioExterno : Funcionario, ISalario, IFuncionarioCadastro
    {
        public string Cargo { get ; set ; }

        public decimal AumentarSalario(decimal valorAumento)
        {
            return Salario += (Salario / 100M) * valorAumento;
        }

        public decimal ExibirSalario()
        {
           return this.Salario;
        }

        public decimal ReduzirSalario(decimal valorReducao)
        {
            return this.Salario -= (Salario / 100M) * valorReducao;
        }

        public void Remover(int Id)
        {
            Console.WriteLine("Funcionário removido");

        }

        public void Salvar(Funcionario funcionario)
        {
            throw new NotImplementedException();
        }
    }
}
