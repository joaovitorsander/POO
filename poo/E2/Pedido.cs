using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo.E2
{
    public class Pedido
    {
        public Cliente Cliente { get; set; }
        public Funcionario Funcionario { get; set; }
        public List<Produto> Produtos { get; set; }
        public Mesa Mesa { get; set; }

        public Pedido(Cliente cliente, Funcionario funcionario, List<Produto> produtos, Mesa mesa)
        {
            Cliente = cliente;
            Funcionario = funcionario;
            Produtos = produtos;
            Mesa = mesa;
        }

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

        public void AdicionarProduto(string nome, double preco)
        {
            Produto produto = new Produto(nome, preco);
            Produtos.Add(produto);
        }

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
