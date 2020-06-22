namespace Aula13Uber
{
    public class Passageiro : Usuario
    {
        public string SolicitarMotorista(){
            return "Procurando motoristas próximos...";
        }

        public bool Pagar(string statusCorrida){

            if(statusCorrida == "Finalizada"){
                return true;
            }
            return false;
        }
    }
}