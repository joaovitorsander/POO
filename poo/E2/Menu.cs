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
        //Atributo privado da classe menu que é uma lista de "produtos", que produtos é uma outra classe
        private List<Produto> produtos;

        //Construtor da classe, quando chamado, o atributo produtos, irá receber uma lista vazia de produtos
        public Menu()
        {
            produtos = new List<Produto>();
        }

        //Método adicionar produto que é passado como parâmetro um objeto produto e é adicionado na lista de produtos, o produto
        public void AdicionarProduto(Produto produto)
        {
            produtos.Add(produto);
        }

        //Método overload de adicionar produto com outra assinatura. Ele recebe o codigo, nome e preco do produto e cria uma variável chamada produto, passando os parâmetros do método
        // e depois adiciona este produto no atributo produtos que é uma lista de produtos  
        public void AdicionarProduto(int codigo, string nome, double preco)
        {
            Produto produto = new Produto(codigo, nome, preco);
            produtos.Add(produto);
        }

        //Método para buscar o produto
        public Produto GetProduto(string nome)
        {
            return produtos.Find(p => p.Nome == nome);
        }

        //método que mostra todos os produtos da lista de produtos. Utilizando o método "MostrarDetalhes" da classe "Produto"
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
