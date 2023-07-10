using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleOOP.Estudo_de_Caso.Entidades;

namespace ConsoleOOP.Estudo_de_Caso.Servicos
{
    public class EnderecoServico
    {
        private string RetornoEndereco { get; set; }

        private readonly string URL = "https://viacep.com.br/ws/";
        
        public bool CEPValido { get; set; }
        public void BuscarEndereco(string cep) 
        {
            var urlBusca = $"{URL}{cep}/json/";
            using var httpClient = new HttpClient();
            using var RetornoURL = httpClient.GetAsync(urlBusca).Result;

            CEPValido = RetornoURL.StatusCode == System.Net.HttpStatusCode.OK;
            RetornoEndereco = RetornoURL.Content.ReadAsStringAsync().Result;
        }

        public Endereco MapearEndereco()
        {
          return  Newtonsoft.Json.JsonConvert.DeserializeObject<Endereco>(RetornoEndereco);
        }

        public bool ExisteCEP()
        {
            return (CEPValido && !this.MapearEndereco().erro);
        }
    }
}
