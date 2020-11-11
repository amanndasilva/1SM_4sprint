namespace Aula_20___fixacao3
{
    public class Restaurante
    {
        public string NomeRestaurante { get; set; }
        public string Endereco { get; set; }

        public string MostrarDados(){
            return $"Restaurante: {NomeRestaurante} \nEndereco: {Endereco} \n\n";
        }
    }
}