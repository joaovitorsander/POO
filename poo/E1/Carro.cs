using System; // Importa o namespace System para usar classes básicas do .NET, como Console

namespace poo.E1
{
    public class Carro
    {
        public string Nome { get; set; }
        public string Ano { get; set; } 
        public string Modelo { get; set; } 
        public string Cor { get; set; } 
        public int Portas { get; set; } 
        public string Categoria { get; set; } 

        // Construtor da classe Carro, inicializa as propriedades com valores fornecidos
        public Carro(string nome, string ano, string modelo, string cor, int portas, string categoria)
        {
            Nome = nome; 
            Ano = ano; 
            Modelo = modelo; 
            Cor = cor; 
            Portas = portas; 
            Categoria = categoria; 
        }

        // Método para exibir informações do carro no console
        public void ExibirInformacoes()
        {
            Console.WriteLine($"Nome: {Nome}, Ano: {Ano}, Modelo: {Modelo}, Cor: {Cor}, Portas: {Portas}, Categoria: {Categoria}");
        }

        // Método sobrecarregado para exibir informações do carro com uma mensagem adicional
        public void ExibirInformacoes(string mensagem)
        {
            Console.WriteLine($"{mensagem} - Nome: {Nome}, Ano: {Ano}, Modelo: {Modelo}, Cor: {Cor}, Portas: {Portas}, Categoria: {Categoria}");
        }

        // Método virtual para simular a ação de dirigir o carro
        public virtual void Dirigir()
        {
            Console.WriteLine($"{Nome} está dirigindo");
        }
    }

    // Classe CarroEsportivo que herda de Carro, representando um carro esportivo
    public class CarroEsportivo : Carro
    {
        // Propriedade específica de CarroEsportivo, representando a velocidade máxima
        public int VelocidadeMaxima { get; set; }

        // Construtor da classe CarroEsportivo, inicializa as propriedades da classe base e a propriedade VelocidadeMaxima
        public CarroEsportivo(string nome, string ano, string modelo, string cor, int portas, string categoria, int velocidadeMaxima)
            : base(nome, ano, modelo, cor, portas, categoria) // Chama o construtor da classe base
        {
            VelocidadeMaxima = velocidadeMaxima; 
        }

        // Sobrescrita do método Dirigir para incluir a velocidade máxima
        public override void Dirigir()
        {
            Console.WriteLine($"{Nome} está dirigindo a uma velocidade máxima de {VelocidadeMaxima} km/h.");
        }
    }
}
