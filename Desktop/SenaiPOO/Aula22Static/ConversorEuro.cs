namespace Aula22Static
{
    public static class ConversorEuro
    {
        public static float CotacaoEuro = 5.87f;

        public static float EuroParaReal(float valorE){
            return valorE * CotacaoEuro;
        }
        public static float RealParaEuro(float valorRe){
            return valorRe / CotacaoEuro;
        }
    }
}