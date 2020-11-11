using System;

namespace Aula25Recursividade
{
    public class Recursividade
    {
        public void GerarSeqenciaFibonacci(int num1, int num2, int vezes)
        {
            if(vezes > 0){
                Console.WriteLine(num1);
                GerarSeqenciaFibonacci(num2, num1 + num2, vezes -1);
            }
        }

        public int GerarFatorial(int num)
        {
            if(num == 1){
                return 1;
            }else{
                return num * GerarFatorial(num - 1);
            }
        }
    }
}