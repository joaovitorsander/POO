using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo.E2
{
    // Classe que representa um produto, implementando a interface genérica IEntidade
    public class Produto : IEntidade<int>
    {
        public int Id { get; set; } // Código identificador do produto
        public string Nome { get; set; } // Nome do produto
        public double Preco { get; set; } // Preço do produto

        // Construtor que inicializa os valores do produto
        public Produto(int id, string nome, double preco)
        {
            Id = id;
            Nome = nome;
            Preco = preco;
        }

        // Método para exibir os detalhes do produto
        public void MostrarDetalhes()
        {
            Console.WriteLine($"ID: {Id}, Produto: {Nome}, Preço: {Preco:C}");
        }
    }
}