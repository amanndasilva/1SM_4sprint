namespace Aula08Abstracao
{
    public class Cartao : Pagamento
    {
        private string token = "ghhghdjkkahys88897hsgddjn";
        public string bandeira { get; set; }
        public int numero { get; set; }
        public string titular { get; set; }
        public string cvc { get; set; }

        public bool validarToken(){
            if(token != null){
                return true;
            }
            return false;
        }
    }
}