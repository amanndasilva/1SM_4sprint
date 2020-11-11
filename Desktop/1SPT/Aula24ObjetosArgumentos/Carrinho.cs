using System;
using System.Collections.Generic;

namespace Aula24ObjetosArgumentos
{
    public class Carrinho
    {
        public float ValorTotal { get; set; }

        List<Produto> carrinho = new List<Produto>();

        public void AdicionarProduto(Produto _produto){
            carrinho.Add(_produto);
        }

        public void Ler(){
            foreach(Produto item in carrinho)
            {
                Console.WriteLine($"Jogo: {item.Nome} \nPreço: {item.Preco} \n");
            }

        }
        public void AlterarItem(int _codigo, Produto _novoProduto){
            carrinho.Find(z => z.Codigo == _codigo).Nome = _novoProduto.Nome;
            carrinho.Find(z => z.Codigo == _codigo).Nome = _novoProduto.Nome;
        }

        public void SomarTotal()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            foreach(Produto item in carrinho)
            {
                ValorTotal += item.Preco;
            }
            Console.WriteLine($"\nValor total dos itens: R${ValorTotal}");

            Console.ResetColor();
        }

        public void RemoverProduto(Produto produto){
            carrinho.Remove(produto);
        }
    }
}