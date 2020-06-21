using System;

namespace Aula18___Dojo
{
    class Program
    {
        static void Main(string[] args)
        {
            Jogador pele = new Jogador();
            pele.Nome = "Pelé";
            pele.Posicao = "Atacante";
            pele.DataDeNascimento = DateTime.Parse("28/10/1940");
            
            pele.MostrarDados();
            Console.WriteLine(pele.CalcularIdade());
            Console.WriteLine(pele.CalcularAposentadoria());
        }
    }
}
