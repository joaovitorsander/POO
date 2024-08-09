using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo.E2
{
    //Criando a classe menu
    public class Menu
    {
        private List<Produto> produtos;

        public Menu()
        {
            produtos = new List<Produto>();
        }

        public void AdicionarProduto(Produto produto)
        {
            produtos.Add(produto);
        }

        public void AdicionarProduto(int codigo, string nome, double preco)
        {
            Produto produto = new Produto(codigo, nome, preco);
            produtos.Add(produto);
        }

        public Produto GetProduto(string nome)
        {
            return produtos.Find(p => p.Nome == nome);
        }

        public void MostrarMenu()
        {
            Console.WriteLine("Menu do restaurante:");
            foreach (var produto in produtos)
            {
                produto.MostrarDetalhes();
            }
        }
    }
}
