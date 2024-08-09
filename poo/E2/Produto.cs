using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo.E2
{
    //Clase produto que herda de "IEntidade", logo precisa ter o atributo nome e o método "MostrarDetalhes"
    public class Produto : IEntidade
    {
        //Atributos publicos codigo, nome e preco
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }

        //Construtor do produto que recebe como parâmetro o codigo, nome e preco
        public Produto(int codigo, string nome, double preco)
        {
            Codigo = codigo;
            Nome = nome;
            Preco = preco;
        }

        //Método "MostrarDetalhes" que precisa ser implementado pois foi herdado da interface e a interface tem este método
        public void MostrarDetalhes()
        {
            Console.WriteLine($"Código: {Codigo}, Produto: {Nome}, Preço: {Preco}");
        }
    }
}
