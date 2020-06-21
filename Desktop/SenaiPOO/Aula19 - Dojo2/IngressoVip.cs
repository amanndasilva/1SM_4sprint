namespace Aula19___Dojo2
{
    public class IngressoVip : Ingresso
    {
        public float ValorAdicional { get; set; }

        public void ImprimirValorVip(){
            float resultado = Valor + ValorAdicional;
            System.Console.WriteLine($"O valor do ingresso Vip é R$ {resultado}.");
        }
    }
}