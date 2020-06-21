using System;

namespace Aula06Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            CPF cpf = new CPF();
            cpf.nome = "Ana";
            
            System.Console.WriteLine(cpf.Saudar());
        }
    }
}
