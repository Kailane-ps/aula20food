namespace _333
{
    public class Program{
        public string Nome {get;set;}

        public string EnderecoAtual {get;set;}

        public Cliente( string _nome, string _enderecoAtual){

            this.Nome = _nome;
            this.EnderecoAtual = _enderecoAtual;
        }
        public void MostrarDados(){
            System.Console.WriteLine($"O Sr {nome} está localizado em {EnderecoAtual}");
        }
    }
}
    