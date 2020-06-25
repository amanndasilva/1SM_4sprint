using System;

namespace Aula25Recursividade
{
    class Program
    {
        static void Main(string[] args)
        {
            Recursividade rec = new Recursividade();
            rec.GerarSeqenciaFibonacci(0,1,20);
            rec.GerarFatorial(5);
        }
    }
}
