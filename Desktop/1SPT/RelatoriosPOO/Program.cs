using System;

namespace RelatoriosPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine();
            Mensal m = new Mensal();
            m.MostrarRelatorio();

            System.Console.WriteLine();
            Anual a = new Anual();
            a.MostrarRelatorio();
        }
    }
}
