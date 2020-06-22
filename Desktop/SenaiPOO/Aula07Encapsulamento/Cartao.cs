namespace Aula07Encapsulamento
{
    public class Cartao
    {
        public string numero { get; set; }
        public string bandeira { get; set; }
        public string titular { get; set; }
        public string token = "fg3g4fywhhgshgdhh6jshh776776zxxwyy09dbkfb";
        public int cvc { get; set; }

        public string AprovarCompra(){
            return "Compra aprovada!";
        }

        private bool ValidarToken(){
            if(token != null && token != ""){
                return true;
            }
            return false;
        }

        protected bool ValidarCompra(){
            return true;
        }
    }
}