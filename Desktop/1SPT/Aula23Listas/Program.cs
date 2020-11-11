using System;
using System.Collections.Generic;

namespace Aula23Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lista smp List<nome da lista>
            List<Produto> prod = new List<Produto>();

            prod.Add(new Produto ("Lenovo", 1, 2000.65f));
            prod.Add(new Produto ("Samsung", 2, 3000.65f));
            prod.Add(new Produto ("Motorola", 3, 3000.65f));
            prod.Add(new Produto ("IPhone", 4, 3000.65f));

                Console.WriteLine("Produtos:\n");

            foreach(Produto p in prod)
            {
                Console.WriteLine($"Marca do celular: {p.Nome} \nPreço: {p.Preco} \n");
            }

            List<Cartao> card = new List<Cartao>();

            card.Add(new Cartao ("Amanda", "Martercard", 969));
            card.Add(new Cartao ("Josefa", "Visa", 787));
            card.Add(new Cartao ("Amarildo", "Elo", 585));
            card.Add(new Cartao ("Brigitte", "Sodexo", 363));

                Console.WriteLine("Cartões:\n");

            foreach(Cartao c in card)
            {
                Console.WriteLine($"Titular: {c.Titular} \nBandeira: {c.Bandeira} \nNúmero: {c.Numero} \n");
            }
        }
    }
}
