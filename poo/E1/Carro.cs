using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo.E1
{
    public class Carro
    {
        //Atributos
        public string Nome { get; set; }
        public string Ano { get; set; }
        public string Modelo { get; set; }
        public string Cor { get; set; }
        public int Portas { get; set; }
        public string Categoria { get; set; }

        //Construtor
        public Carro(String nome, String ano, String modelo, String cor, int portas, String categoria)
        {
            Nome = nome;
            Ano = ano;
            Modelo = modelo;
            Cor = cor;
            Portas = portas;
            Categoria = categoria;
        }

        //Método
        public void ExibirInformacoes()
        {
            Console.WriteLine($"Nome: {Nome}, Ano: {Ano}, Modelo: {Modelo}, Cor: {Cor}, Portas: {Portas}, Categoria: {Categoria}");
        }

        //Método de sobrecarga
        public void ExibirInformacoes(String mensagem)
        {
            Console.WriteLine($"{mensagem} - Nome: {Nome}, Ano: {Ano}, Modelo: {Modelo}, Cor: {Cor}, Portas: {Portas}, Categoria: {Categoria}");
        }

        //Método virtual
        public virtual void Dirigir()
        {
            Console.WriteLine($"{Nome} está dirigindo");
        }
    }

    public class CarroEsportivo : Carro
    {
        public int VelocidadeMaxima { get; set; }

        public CarroEsportivo(string nome, string ano, string modelo, string cor, int portas, string categoria, int velocidadeMaxima) : base(nome, ano, modelo, cor, portas, categoria)
        {
            VelocidadeMaxima = velocidadeMaxima;
        }

        // Sobrescrita de método
        public override void Dirigir()
        {
            Console.WriteLine($"{Nome} está dirigindo a uma velocidade máxima de {VelocidadeMaxima} km/h.");
        }
    }
}

