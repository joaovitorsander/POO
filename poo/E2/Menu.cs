using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo.E2
{
    namespace poo.E2
    {
        public class Menu<T> where T : IEntidade<int>
        {
            private List<T> itens;

            public Menu()
            {
                itens = new List<T>();
            }

            // Adiciona itens ao menu, mantendo responsabilidade única (SOLID - Single Responsibility Principle).
            public void AdicionarItem(T item)
            {
                if (item == null)
                {
                    Console.WriteLine("Item inválido.");
                    return;
                }
                itens.Add(item);
            }

            // Busca um item pelo nome, aplicando separação de responsabilidade (SOC).
            public T ObterItemPorNome(string nome)
            {
                return itens.FirstOrDefault(p => p.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));
            }

            // Exibe o menu do restaurante
            public void MostrarMenu()
            {
                Console.WriteLine("Menu do restaurante:");
                foreach (var item in itens)
                {
                    item.MostrarDetalhes();
                }
            }
        }
    }
}

