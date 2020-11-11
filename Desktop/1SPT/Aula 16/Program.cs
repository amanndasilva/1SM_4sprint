using System;

namespace CadastroAluno
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno marcos = new Aluno();
            marcos.nome = "Marcos";
            marcos.idade = 18;
            marcos.bolsista = false;
            marcos.valorMensalidade = 2000f;
            marcos.mediaFinal = 10f;

            Console.WriteLine("Marcos: "+marcos.VerMediaFinal());
            Console.WriteLine("Marcos: "+marcos.VerMensalidade());

            Aluno ana = new Aluno();
            ana.nome = "Ana";
            ana.idade = 18;

            Console.WriteLine("Aluno bolsista?");
            ana.bolsista = ana.TraduzConsole(Console.ReadLine());

            ana.valorMensalidade = 2000f;
            ana.percentual = 40;
            ana.mediaFinal = 9.8f;

            Console.WriteLine("Ana: "+ana.VerMediaFinal());
            Console.WriteLine("Ana: "+ana.VerMensalidade());
        }
    }
}
