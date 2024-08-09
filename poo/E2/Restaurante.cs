using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo.E2
{
    public class Restaurante
    {
        //Atributo público "Nome" e Menu que é do tipo da class "Menu"
        public string Nome {  get; set; }
        public Menu Menu { get; set; } 

        //Construtor do restaurante, que recebe o parâmetro "Nome"
        public Restaurante(String nome) 
        {
            Nome = nome;
            Menu = new Menu();
        }

        //Método mostrar detalhes que exibe o nome do restaurante, mostra o menu usandoo o método "MostrarMenu" da class "Menu"
        public void MostrarDetalhes()
        {
            Console.WriteLine($"Restaurante: {Nome}");
            Menu.MostrarMenu();
        }
    }
}
