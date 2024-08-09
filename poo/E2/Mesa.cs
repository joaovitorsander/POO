using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo.E2
{
    public class Mesa
    {
        //Criação do atributo Numero
        public int Numero {  get; set; }

        //Construtor da classe mesa, que tem que passar como parâmetro o número da mesa
        public Mesa(int numero)
        {
            Numero = numero;
        }

        //Método mostrar detalhes da mesa
        public void MostrarDetalhes()
        {
            Console.WriteLine($"Mesa: {Numero}");
        }
    }
}
