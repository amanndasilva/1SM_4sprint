namespace Aula08Abstracao
{
    public class CartaoDebito : Cartao
    {
        public string saldo { get; set; }

        public string Transferir(float valor){
            return $"R${valor} transferido da sua conta.";
        }

        public string PagarTitulo(){
            return "Título pago com cartão de débito.";
        }
    }
}