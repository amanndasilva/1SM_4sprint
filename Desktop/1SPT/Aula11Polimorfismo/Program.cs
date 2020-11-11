using System;

namespace Aula11Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculo cal = new Calculo();
            System.Console.WriteLine(cal.Calcular());

            System.Console.WriteLine(cal.Calcular(200));

            System.Console.WriteLine(cal.Calcular(200, 400));

            System.Console.WriteLine(cal.Calcular("200", "400"));
        }
    }
}
