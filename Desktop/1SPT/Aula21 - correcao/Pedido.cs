namespace Aula21___correcao
{
    public class Pedido
    {
        public string[] Itens { get; set; }
        public Cliente Cliente { get; set; }
        public Restaurante Restaurante { get; set; }
        public string FormaPGT { get; set; }
        public bool PedidoPago { get; set; }

        public string EntregarPedido(){

            string retorno = "Pedido entregue! \n";
            retorno += Restaurante.MostrarDados();
            retorno += Cliente.MostrarDados();

            return retorno;
        }
    }
}