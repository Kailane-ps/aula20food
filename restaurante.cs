namespace _333
{
    public class Program
    {
        public string NomeFantasia{get;set}

        public string Endereco {get;set}

        public void MostrarDados(){

            System.Console.WriteLine($"A{NomeFantasia} está localizada na {Endereco}");
        }

        public Restaurante( string _nomefantasia, string _endereco){
            this.NomeFantasia = _nomefantasia;
            this.Endereco = _endereco;
        }
    }
}
