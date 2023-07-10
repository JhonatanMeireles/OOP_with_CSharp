using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleOOP.Aula8_and_9.TiposDeClasses
{
    public static class TratamentoTexto
    {
        public static int TotalString(string texto) => texto.Length;

        public static string Maiusculo(string texto) => texto.ToUpper();
    }
}
