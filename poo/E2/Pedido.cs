using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo.E2
{
    public class Pedido
    {
        //Atributos da classe pedido, cliente do tipo class cliente, funcionario do tipo class funcionario, produtos que é uma lista de produtos e mesa que é uma class da mesas
        public Cliente Cliente { get; set; }
        public Funcionario Funcionario { get; set; }
        public List<Produto> Produtos { get; set; }
        public Mesa Mesa { get; set; }

        //Construtor do pedido que tem que passar um cliente, um funcionario, uma lista de produtos e uma mesa
        public Pedido(Cliente cliente, Funcionario funcionario, List<Produto> produtos, Mesa mesa)
        {
            Cliente = cliente;
            Funcionario = funcionario;
            Produtos = produtos;
            Mesa = mesa;
        }

        //Método adicionar produto que recebe como parâmetro um produto
        //Verifica se o produto é diferente de null, se for, adiciona na lista de produtos
        //senão, gera uma mensagem de produto não encontrado
        //esse método não entendi muito bem, se puder me explicar, por favor
        public void AdicionarProduto(Produto produto) 
        {
            if (produto != null)
            {
                Produtos.Add(produto);
            }
            else
            {
                Console.WriteLine("Produto não encontrado");
            }
        }

        //método overload do adicionar produto que espera o código do produto, nome e preço e depois cria um novo produto com estes parâmetros e adiciona na lista
        public void AdicionarProduto(int codigo, string nome, double preco)
        {
            Produto produto = new Produto(codigo, nome, preco);
            Produtos.Add(produto);
        }

        //Método mostrar detalhes, que mostra os detalhes do pedido, chamando os métodos de mostrardetalhes das classes, cliente, funcionário, mesa e produto
        public void MostrarDetalhes()
        {
            Console.WriteLine("Detalhes do pedido:");
            Cliente.MostrarDetalhes();
            Funcionario.MostrarDetalhes();
            Mesa.MostrarDetalhes();
            Console.WriteLine("Produtos:");
            foreach (var produto in Produtos)
            {
                produto.MostrarDetalhes();
            }
        }
    }
}
