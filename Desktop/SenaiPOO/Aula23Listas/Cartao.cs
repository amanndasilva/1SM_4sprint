namespace Aula23Listas
{
    public class Cartao
    {
        public string Bandeira { get; set; }
        public string Titular { get; set; }
        public int Numero { get; set; }

        public Cartao(){

        }

        public Cartao(string _titular, string _bandeira, int _numero){
            this.Titular = _titular;
            this.Bandeira = _bandeira;
            this.Numero = _numero;
        }
    }
}