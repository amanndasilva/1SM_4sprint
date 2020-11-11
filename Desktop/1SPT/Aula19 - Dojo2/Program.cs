using System;

namespace Aula19___Dojo2
{
    class Program
    {
        static void Main(string[] args)
        {
            IngressoVip folha = new IngressoVip();
            folha.Valor = 15f;
            folha.ValorAdicional = 15.75f;
            folha.ImprimirValor();
            folha.ImprimirValorVip();

            System.Console.WriteLine($"A diferença entre os bilhetes é {folha.ValorAdicional}.");
        }
    }
}
