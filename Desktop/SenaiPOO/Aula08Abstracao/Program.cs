using System;

namespace Aula08Abstracao
{
    class Program
    {
        static void Main(string[] args)
        {
            CartaoCredito elo = new CartaoCredito();

            System.Console.WriteLine("Digite a data do pagamento:");
            elo.data = DateTime.Parse(Console.ReadLine());
            System.Console.WriteLine("Data digitada: "+elo.data);
        }
    }
}
