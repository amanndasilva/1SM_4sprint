using System;
using System.Collections.Generic;

namespace Aula27_28_29_30
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p1 = new Produto();
            p1.Codigo = 2;
            p1.Nome = "Mondial";
            p1.Preco = 550f;

            p1.Adicionar(p1);
            //p1.Remover("Mondial");

            Produto alterado = new Produto();
            alterado.Codigo = 2;
            alterado.Nome = "Philco";
            alterado.Preco = 400f;

            p1.Alterar(alterado);

            List<Produto> lista = p1.Ler();

            foreach (Produto item in lista)
            {
                Console.WriteLine($"R$ {item.Preco} - {item.Nome}");
            }
        }
    }
}
