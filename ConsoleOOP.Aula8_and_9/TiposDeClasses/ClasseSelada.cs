using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleOOP.Aula8_and_9.TiposDeClasses
{
    public class PessoaFisica
    {
        public string Nome { get; set; }
    }

    public sealed class ValidacaoPessoaFisica
    {
        public ValidacaoPessoaFisica(PessoaFisica pessoaFisica)
        {
            if (string.IsNullOrEmpty(pessoaFisica.Nome))
                throw new Exception("Nome é obrigatório");
        }
    }
}
