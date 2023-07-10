using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleOOP.Aula10_and11.Entidades
{
    public abstract class DadosPessoaBase
    {

        public int Id { get; set; }
        public string Nome { get; set; }

        public string NroDocumento { get; set; }
        
        protected DadosPessoaBase() { }
        protected DadosPessoaBase(int id, string nome, string nroDocumento)
        {
            Id = id;
            Nome = nome;
            NroDocumento = nroDocumento;
        }

        public virtual string ExibirDadosCompletos() => $"{Id} - {Nome} - {NroDocumento}";

        public abstract void FormatarDocumento();
    }

    public class PessoaFisica : DadosPessoaBase
    {
        public string RG { get; set; }

        public PessoaFisica(int id, string nome, string nroDocumento, string rg) : base(id, nome, nroDocumento)
        {
            this.RG = rg;
        }

        public override string ToString() 
            => $"{this.Id} - {this.Nome} - {this.NroDocumento} - {this.RG}";

        public override void FormatarDocumento()
        {
            NroDocumento = Convert.ToUInt64(NroDocumento).ToString(@"###\.###\.###\-##") ;
        }

    }

    public class PessoaJuridica : DadosPessoaBase 
    {
        public string InscricaoEstadual { get; set; }

        public override string ExibirDadosCompletos()
        {
            return $"{base.ExibirDadosCompletos()} - {this.InscricaoEstadual}";
        }

        public override void FormatarDocumento()
        {
            NroDocumento = Convert.ToUInt64(NroDocumento).ToString(@"##\.###\.###\/####\-##");
        }
    }

    public class PessoaFornecedor : DadosPessoaBase 
    {
        public string Segmento { get; set; }
        public override void FormatarDocumento()
        {
            NroDocumento = Convert.ToUInt64(NroDocumento).ToString(@"##\.###\.###/####\-##");
        }
    }
}
