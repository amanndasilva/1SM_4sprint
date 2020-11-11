using System;

namespace Aula_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Personagem okoye = new Personagem();
            okoye.lanca = "Bleeding edge.";

            Console.WriteLine(okoye.nome);

            Console.WriteLine(okoye.idade);

            Console.WriteLine(okoye.lanca);

            Console.WriteLine(okoye.Atacar());
        }
    }
}
