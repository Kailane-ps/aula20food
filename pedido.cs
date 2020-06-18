using System;
namespace _333
{
    
    public class Pedid
    {
        public string Itens {get;set;}

        public string Cliente {get;set}

        public string FormaDePa {get;set}

        public bool PedidoPago {get;set;}

        public string Restaurante {get;set;}

       

        public string EntregarPedido(){
            return "O pedido saiu para entrega..."
        }

    }
    
}