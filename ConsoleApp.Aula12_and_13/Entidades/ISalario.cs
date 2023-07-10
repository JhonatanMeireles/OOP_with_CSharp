namespace ConsoleApp.Aula12_and_13.Entidades
{
    public interface ISalario
    {
        public String Cargo{ get; set; }
        decimal AumentarSalario(decimal valorAumento);

        decimal ReduzirSalario(decimal valorReducao);

        decimal ExibirSalario();
    }

    public interface IFuncionarioCadastro
    {
        void Salvar(Funcionario funcionario);

        void Remover(int Id);
    }

    
}
