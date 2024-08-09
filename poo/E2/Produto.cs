using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo.E2
{
    public class Produto : IEntidade
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }

        public Produto(int codigo, string nome, double preco)
        {
            Codigo = codigo;
            Nome = nome;
            Preco = preco;
        }

        public void MostrarDetalhes()
        {
            Console.WriteLine($"Código: {Codigo}, Produto: {Nome}, Preço: {Preco}");
        }
    }
}
