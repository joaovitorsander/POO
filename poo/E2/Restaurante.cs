using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo.E2
{
    public class Restaurante
    {
        
        public string Nome {  get; set; }
        public Menu Menu { get; set; } 

        
        public Restaurante(String nome) 
        {
            Nome = nome;
            Menu = new Menu();
        }

        public void MostrarDetalhes()
        {
            Console.WriteLine($"Restaurante: {Nome}");
            Menu.MostrarMenu();
        }
    }
}
