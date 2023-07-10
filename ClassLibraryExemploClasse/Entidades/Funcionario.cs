using System.Runtime.CompilerServices;

namespace ClassLibraryExemploClasse.Entidades
{
    public class Funcionario
    {
        public string? Nome { get; set; }

        public string? Cargo { get; set; }

        private decimal Salario { get; set; }

        public Funcionario() { }

        public Funcionario(string nome, string cargo, decimal salario)
        {
            Nome = nome;
            Cargo = cargo;
            Salario = salario;
        }

        public Funcionario
            (string nome,
            string cargo,
            decimal salario,
            string acao
            ) : this(nome, cargo, salario)
        {
            this.ExibirMensagemContratacao(acao);   
        }


        public void AumentarSalario( decimal salarioValor) => this.Salario += salarioValor;

        public void AumentarSalario (double salarioPercentual) 
        {
            this.Salario *= (decimal)(salarioPercentual / 100d) + 1;
        }

        private decimal AumentarSalario() => this.Salario * 1.1M;
        private decimal AumentarSalarioInterno(decimal salarioPercentual) => this.Salario * ((salarioPercentual / 100) + 1);

        public void DiminuirSalario(decimal salarioValor)
        {   
            if(salarioValor >= this.Salario) 
            {
                Console.WriteLine("Não é possível aplicar a diminuição do salário. Pois o valor excede o valor atual!");
                return;
            }
            this.Salario -= salarioValor;
        }
        public decimal ExibirSalario() => this.Salario;


        private void ExibirMensagemContratacao(string acao)
        {
            if (acao == "Contratar")
            { 
                Console.WriteLine($"Contratação Feita de {this.Nome}");
                Console.WriteLine($"Em 3 meses você terá um aumento de 10%, e o seu salário será: {this.AumentarSalario()}");
               // Console.WriteLine($"Em 6 meses você terá um aumento de mais 5%, e o seu salário será:{this.AumentarSalarioInterno(salarioPercentual: 5M)+Salario}");
            }
        }

    }
}
