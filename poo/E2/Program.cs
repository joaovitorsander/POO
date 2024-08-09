using System;
using System.Collections.Generic;

namespace poo.E2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solicitar nome e idade do cliente
            Console.Write("Digite seu nome: ");
            string nomeCliente = Console.ReadLine();

            Console.Write("Digite sua idade: ");
            int idadeCliente = int.Parse(Console.ReadLine());

            // Criar cliente com base nas informações fornecidas
            Cliente cliente = new Cliente(nomeCliente, idadeCliente);

            // Criar funcionário (garçom fixo)
            Funcionario garcon = new Funcionario("Maria", 28, "Garçonete");

            // Criar restaurante e mesa
            Restaurante restaurante = new Restaurante("Restaurante Exemplo");
            Mesa mesa1 = new Mesa(1);

            // Adicionar produtos ao menu
            restaurante.Menu.AdicionarProduto(new Produto(1, "Hamburguer", 25.00));
            restaurante.Menu.AdicionarProduto(2, "Batata Frita", 10.00);
            restaurante.Menu.AdicionarProduto(new Produto(3, "Refrigerante", 5.00));

            // Criar uma lista vazia de produtos
            List<Produto> produtos = new List<Produto>();

            // Criar pedido com a lista de produtos
            Pedido pedido = new Pedido(cliente, garcon, produtos, mesa1);

            bool running = true;

            while (running)
            {
                Console.Clear();
                Console.WriteLine($"Bem-vindo ao Restaurante Exemplo, {cliente.Nome}!");
                Console.WriteLine("Selecione uma opção:");
                Console.WriteLine("1. Ver Menu");
                Console.WriteLine("2. Adicionar Produto ao Pedido");
                Console.WriteLine("3. Ver Detalhes do Pedido");
                Console.WriteLine("4. Sair");
                Console.Write("Opção: ");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.Clear();
                        restaurante.Menu.MostrarMenu();
                        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal...");
                        Console.ReadKey();
                        break;

                    case "2":
                        Console.Clear();
                        Console.WriteLine("Digite o nome do produto que deseja adicionar ao pedido:");
                        string nomeProduto = Console.ReadLine();
                        Produto produto = restaurante.Menu.GetProduto(nomeProduto);
                        if (produto != null)
                        {
                            pedido.AdicionarProduto(produto);
                            Console.WriteLine($"{produto.Nome} adicionado ao pedido com sucesso!");
                        }
                        else
                        {
                            Console.WriteLine("Produto não encontrado no menu.");
                        }
                        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal...");
                        Console.ReadKey();
                        break;

                    case "3":
                        Console.Clear();
                        pedido.MostrarDetalhes();
                        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal...");
                        Console.ReadKey();
                        break;

                    case "4":
                        running = false;
                        Console.WriteLine("Obrigado por usar o sistema do restaurante!");
                        break;

                    default:
                        Console.WriteLine("Opção inválida! Pressione qualquer tecla para tentar novamente...");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
