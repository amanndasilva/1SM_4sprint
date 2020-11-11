using System;

namespace Aula22Static
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Preço do Dolar convertido em Reais: "+ ConversorDolar.DolarParaReal(25));
            Console.WriteLine("Preço do Real convertido em Dolar: "+ ConversorDolar.RealParaDolar(100));

            Console.WriteLine("-------------");

            Console.WriteLine("Preço do Euro convertido em Reais: "+ ConversorEuro.EuroParaReal(40));
            Console.WriteLine("Proço do Real convertido em Euro: "+ ConversorEuro.RealParaEuro(160));
        }
    }
}
