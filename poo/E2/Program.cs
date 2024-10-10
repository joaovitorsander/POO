using System;
using System.Collections.Generic;

namespace poo.E2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Captura os dados do cliente
            Console.Write("Digite seu nome: ");
            string nomeCliente = Console.ReadLine();

            Console.Write("Digite sua idade: ");
            int idadeCliente = int.Parse(Console.ReadLine());

            // Cria instâncias de Cliente e Funcionario
            Cliente cliente = new Cliente(1, nomeCliente, idadeCliente);
            Funcionario garcon = new Funcionario(1, "Maria", 28, "Garçonete");

            // Cria o restaurante e adiciona produtos ao menu
            Restaurante restaurante = new Restaurante("Restaurante Exemplo");
            restaurante.Menu.AdicionarItem(new Produto(1, "Hamburguer", 25.00));
            restaurante.Menu.AdicionarItem(new Produto(2, "Batata Frita", 10.00));
            restaurante.Menu.AdicionarItem(new Produto(3, "Refrigerante", 5.00));

            // Cria o pedido e adiciona produtos
            Pedido<Produto> pedido = new Pedido<Produto>(cliente, garcon, new Mesa(1));
            pedido.AdicionarItem(restaurante.Menu.ObterItemPorNome("Hamburguer"));

            // Exibe os detalhes do pedido
            pedido.MostrarDetalhes();

            // Pausa o programa para que o console permaneça aberto
            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}