using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace poo.E2
{
    public class Cliente : Pessoa
    {
        public Cliente(string nome, int idadade) : base(nome, idadade)
        {
        }
        public override void MostrarDetalhes()
        {
            Console.WriteLine($"Cliente: {Nome}, Idade: {Idade}");
        }
    }
}
