using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo.E2
{
    public class Mesa
    {
        public int Numero {  get; set; }

        public Mesa(int numero)
        {
            Numero = numero;
        }

        public void MostrarDetalhes()
        {
            Console.WriteLine($"Mesa: {Numero}");
        }
    }
}
