using System;

namespace Aula21___correcao
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente ana = new Cliente("Ana");
            ana.Endereco = "Avenida D. Pedro, 123";
            Console.WriteLine(ana.MostrarDados());

            Restaurante madero = new Restaurante("Madero");
            madero.Endereco = "Avenida Ricardo Jafet";
            System.Console.WriteLine(madero.MostrarDados());

            Pedido pedido1 = new Pedido();
            pedido1.Cliente = ana;
            pedido1.Restaurante = madero;
            Console.WriteLine(pedido1.EntregarPedido());
        }
    }
}
