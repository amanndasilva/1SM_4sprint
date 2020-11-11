using System;

namespace Aula07Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Cartao cartao = new Cartao();
            
            Masteracrd master = new Masteracrd();
            master.titular = "Ana";
            master.parcelas = 8;
            master.ComparComDesconto(10f);
        }
    }
}
