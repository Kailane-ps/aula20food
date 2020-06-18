using System;

namespace _333
{
    class Program
    {
        static void Main(string[] args)
        {
            Restaurante bar = new Restaurante("Lojinha do Zé","rua das flores nº111");
            bar.MostrarDados();
            Cliente Maria = new Restaurante ("Maria", "rua amaro nº300");
            Maria.MostrarDados();
            Pedido pedido = new Pedido();
            pedido.Restaurante();
        }
    }
}
