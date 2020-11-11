namespace Aula_20___fixacao3
{
    public class Cliente
    {
        public string NomeCliente { get; set; }
        public string Endereco { get; set; }

        public string MostrarDados(){
            return $"Cliente: {NomeCliente} \nEndereco: {Endereco} \n\n";
        }
    }
}