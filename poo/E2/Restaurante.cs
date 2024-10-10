using poo.E2.poo.E2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo.E2
{
    public class Restaurante
    {
        public string Nome { get; set; }
        public Menu<Produto> Menu { get; set; }

        public Restaurante(string nome)
        {
            Nome = nome;
            Menu = new Menu<Produto>();
        }

        // Exibe detalhes do restaurante e do menu
        public void MostrarDetalhes()
        {
            Console.WriteLine($"Restaurante: {Nome}");
            Menu.MostrarMenu();
        }
    }
}


