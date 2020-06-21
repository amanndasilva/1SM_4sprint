using System;

namespace Aula18___Dojo
{
    public class Jogador
    {
        public string Nome { get; set; }
        public string Posicao { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public float Altura { get; set; }
        public float Peso { get; set; }
        public string Nacionalidade { get; set; }
        
        public string MostrarDados(){
            return $"Nome: {Nome}, Posicao: {Posicao}, Data de Nascimento: {DataDeNascimento}, Altura: {Altura}, Peso: {Peso}, Nacionalidade: {Nacionalidade}";
        }
        
        public int idade { get; set; }

        public int CalcularIdade(){
            int anoNasc = Int32.Parse(DataDeNascimento.ToString().Split('/' , ' ')[2]);
            int anoAtual = Int32.Parse(DateTime.Now.ToString().Split('/' , ' ')[2]);

            idade = anoAtual - anoNasc;

            return idade;
        }

        public string CalcularAposentadoria(){
            string aposentadoria = "";
            
            if(Posicao == "Atacante" && idade >= 35){
                aposentadoria = "Você pode se aposentar!";
            }else
            if(Posicao == "Meio Campo" && idade >= 38){
                aposentadoria = "Você pode se aposentar!";
            }
            else           
            if(Posicao == "Defesa" && idade >= 40){
                aposentadoria = "Você pode se aposentar!";
            }
            else{
                aposentadoria = "Você ainda não pode se aposentar!";
            }
            return aposentadoria;
        }
    }
}