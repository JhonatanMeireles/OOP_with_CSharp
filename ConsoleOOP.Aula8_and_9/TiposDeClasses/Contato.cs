using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleOOP.Aula8_and_9.TiposDeClasses
{
    public class Contato
    {
        public string Nome { get; set; }

        public int Contador { get; set; }

        public static int TotalContatos { get; set; }
        public Contato(string nome)
        {
            Nome = nome;
            Contador++;
            TotalContatos++;
        }

        public static void ExibirMensagem() => Console.WriteLine("Classe Contato");

        
    }
}
