using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo.E1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Criando os objetos
            Carro fusca = new Carro("Fusca", "1980", "Clássico", "Azul", 2, "Hatchback");
            CarroEsportivo mustang = new CarroEsportivo("Mustang", "2022", "Esportivo", "Vermelho", 2, "Coupe", 280);

            //Métodos
            fusca.ExibirInformacoes();
            mustang.ExibirInformacoes("Informação adicional");
            fusca.Dirigir();
            mustang.Dirigir();

            Console.ReadLine();

        }
    }
}
