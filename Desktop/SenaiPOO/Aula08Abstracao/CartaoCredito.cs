namespace Aula08Abstracao
{
    public class CartaoCredito : Cartao
    {
        public string limite { get; set; }

        public float AumentarLimite(float limiteAtual, float acrescimo){

            return limiteAtual + acrescimo;
        }
        public string BloquearCartaoCredito(){
            return "Cartão de crédito bloqueado";
        }
    }
}