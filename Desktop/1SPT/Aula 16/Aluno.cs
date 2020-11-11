namespace CadastroAluno
{
    public class Aluno
    {
        public string nome;
        public int idade;
        public bool bolsista;
        public float percentual;
        public float mediaFinal;
        public float valorMensalidade;

        public float VerMediaFinal(){
            return mediaFinal;
        }

        public float VerMensalidade(){

            float valorCalculado = valorMensalidade;
            if(bolsista == true){
                valorCalculado = valorMensalidade - (valorMensalidade * percentual /100);
            }

            return valorCalculado;
        }

        public bool TraduzConsole(string condicao){
            if(condicao == "sim"){
                bolsista = true;
            }else{
                bolsista = false;
            }
            return bolsista;
        }
    }
}