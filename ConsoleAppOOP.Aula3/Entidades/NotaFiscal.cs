namespace ConsoleAppOOP.Aula3.Entidades
{
    public class NotaFiscal
    {
        public string TipoDocumento = "NFe";

        private int _numero;

        private string _sucesso = "Até 100 Emissões. Sua Nota foi a ";
        private string _erro = "Não houve NF emitida";

        public int Numero
        {
            get { return _numero = _numero + 2; }
            set
            {
                if (value > 10)
                {
                    throw new Exception("Digite um número menor até 10.");
                }
                _numero = value;
            }
        }

        public string Limite
        {
            get
            {
                if (_numero > 0)
                {
                    return $"Até 100 Emissões. Sua Nota foi a {this._numero}";
                }

                return "Não houve NF emitida";
            }
        }

        public string Limite2 => _numero > 0 ? $"{_sucesso} {this._numero}" : _erro; // A mesma validação da propriedade limite de uma forma mais moderna e atualizada



        public decimal Valor => 10M; // validação diretamente na propriedade Valor com o get escondido
        //public int Numero { get; set; }
    }


}
