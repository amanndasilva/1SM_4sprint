using System;

namespace Aula_20___fixacao3
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente ana = new Cliente();
            ana.NomeCliente = "Ana";
            ana.Endereco = "Avenida D. Pedro, 123";
            Console.WriteLine(ana.MostrarDados());

            Restaurante madero = new Restaurante();
            madero.NomeRestaurante = "Madero";
            madero.Endereco = "Avenida Ricardo Jafet";
            System.Console.WriteLine(madero.MostrarDados());

            Pedido pedido1 = new Pedido();
            pedido1.Cliente = ana.NomeCliente;
            pedido1.Restaurante = madero.NomeRestaurante;
            Console.WriteLine(pedido1.EntregarPedido());
        }
    }
}
