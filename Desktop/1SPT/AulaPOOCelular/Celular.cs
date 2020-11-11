namespace AulaPOOCelular
{
    public class Celular
    {
        public string cor;
        public string modelo;
        public float tamanho;
        public bool ligado;

        public string Ligar(){
            ligado = true;
            return "Ligando celular.";
        }
        public string Desligar(){
            ligado = false;
            return "Desligando celular.";
        }
        public string FazerLigacao(){
            return "Fazendo ligação.";
        }
        public string EnviarMensagem(){
            return "Enviando mensagem.";
        }
    }
}