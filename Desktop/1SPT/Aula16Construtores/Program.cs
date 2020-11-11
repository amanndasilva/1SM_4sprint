using System;

namespace Aula16Construtores
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto vaso = new Produto();
            System.Console.WriteLine("O código do produto é "+ vaso.Codigo);

            System.Console.WriteLine("");

            Produto bola = new Produto(558, "Penalty", "Rosa e branco", 5);
            System.Console.WriteLine("O código do produto é "+bola.Codigo);   
            System.Console.WriteLine("O nome do produto é "+bola.Nome);   
            System.Console.WriteLine("A descrição do produto é "+bola.Descricao);   
            System.Console.WriteLine("O número desse tipo de produto no estoque é "+bola.Estoque);   
        }
    }
}
