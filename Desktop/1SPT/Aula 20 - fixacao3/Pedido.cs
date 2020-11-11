namespace Aula_20___fixacao3
{
    public class Pedido
    {
        public string[] Itens { get; set; }
        public string Cliente { get; set; }
        public string Restaurante { get; set; }
        public string FormaPGT { get; set; }
        public bool PedidoPago { get; set; }

        public string EntregarPedido(){

            return $"Pedido entregue por: {Restaurante}, para o (a) cliente {Cliente}.";
        }
    }
}