using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleOOP.Aula4_and_5.Construtor
{
    public class Carro
    {
        public string? Marca { get; set; }

        public string? Modelo { get; set; }

        public string? Cor { get; set; }

        public int Ano { get; set; }

        public decimal Valor { get; set; }

        public Carro() 
        {
            Console.WriteLine("Fui instânciada");
        }

        public Carro(string? marca, string? modelo, string? cor, int ano, decimal valor)
        {
            if(ano >= 2010) 
            {
                throw new Exception("Não preencha com carro com ano menor quer 2000");
            }
            Marca = marca;
            Modelo = modelo;
            Cor = cor;
            Ano = ano;
            Valor = valor;
        }
    }
}
