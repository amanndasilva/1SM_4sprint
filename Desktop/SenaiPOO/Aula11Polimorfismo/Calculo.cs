namespace Aula11Polimorfismo
{
    public class Calculo
    {
        public string Calcular(){
            return "Não precisamos fazer nenhum cálculo.";
        }

        public string Calcular(int num1){
            return "O número 1 esclhido foi "+ num1;
        }

        public string Calcular(int num1, int num2){
            return "O cálculo do número 1 com o número 2 é: "+ (num1 + num2);
        }

        public string Calcular(string num1, string num2){
            return $"Os números escolhidos são {num1} e {num2}.";
        }
    }
}