namespace ConsoleOOP.Aula16_and_17.Extensions
{
    public static class NumeroExtensions
    {
        public static decimal ConverteParaDecimal(this string str)
        {
            if (string.IsNullOrEmpty(str)) return 0;
            return decimal.TryParse( str.Replace(".", ","), out decimal valor) ? valor : 0;
        }

    }
}
