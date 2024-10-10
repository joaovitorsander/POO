using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo.E2
{
    public class Pedido<T> where T : IEntidade<int>
    {
        public Cliente Cliente { get; set; }
        public Funcionario Funcionario { get; set; }
        public List<T> Itens { get; set; }
        public Mesa Mesa { get; set; }

        public Pedido(Cliente cliente, Funcionario funcionario, Mesa mesa)
        {
            Cliente = cliente;
            Funcionario = funcionario;
            Itens = new List<T>();
            Mesa = mesa;
        }

        // Adiciona itens ao pedido, seguindo o princípio de responsabilidade única.
        public void AdicionarItem(T item)
        {
            if (item == null)
            {
                Console.WriteLine("Item não encontrado");
                return;
            }
            Itens.Add(item);
        }

        // Exibe detalhes do pedido, organizando informações de forma clara e limpa.
        public void MostrarDetalhes()
        {
            Console.WriteLine("Detalhes do pedido:");
            Cliente.MostrarDetalhes();
            Funcionario.MostrarDetalhes();
            Mesa.MostrarDetalhes();
            Console.WriteLine("Itens:");
            foreach (var item in Itens)
            {
                item.MostrarDetalhes();
            }
        }
    }
}


