namespace Aula07Encapsulamento
{
    public class Masteracrd : Cartao
    {
        public int parcelas { get; set; }

        public void ComparComDesconto(float desconto){
            cvc = 500;
            
            System.Console.WriteLine($"O desconto de R${desconto} foi aplicado, com o total de {parcelas} parcelas.");
        }
    }
}