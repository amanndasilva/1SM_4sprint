using System;
using System.Collections.Generic;

namespace Aula26Interfaces
{
    public class Carrinho : ICarrinho
    {
        public float ValorTotal { get; set; }
        List <Produto> carrinho = new List<Produto>();
        public void Alterar(int _cod, Produto produto)
        {
            carrinho.Find(a => a.Codigo == _cod).Nome = produto.Nome;
            carrinho.Find(b => b.Codigo ==  _cod).Preco = produto.Preco;
        }

        public void Excluir(Produto _produto)
        {
            carrinho.Remove(_produto);
        }

        public void Incluir(Produto _produto)
        {
            carrinho.Add(_produto);
        }

        public void Ler()
        {
            foreach(Produto p in carrinho){
                System.Console.WriteLine($"Preço: R$ {p.Preco} \nNome: {p.Nome} \n");
            }
        }

        public void SomarTotal()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            foreach(Produto p in carrinho)
            {
                ValorTotal += p.Preco;
            }
            System.Console.WriteLine($"\nValor total dos itens: R$ {ValorTotal}.");
            Console.ResetColor();
        }
    }
}