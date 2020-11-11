namespace Aula22Static
{
    public static class ConversorDolar
    {
        public static float CotacaoDolar = 5.21f;

        public static float DolarParaReal(float valorD){
            return valorD * CotacaoDolar;
        }
        public static float RealParaDolar(float valorR){
            return valorR / CotacaoDolar;
        }
    }
}