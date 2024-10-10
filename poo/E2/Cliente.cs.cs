using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace poo.E2
{
    public class Cliente : Pessoa<int>
    {
        public Cliente(int id, string nome, int idade) : base(id, nome, idade) { }

        public override void MostrarDetalhes()
        {
            Console.WriteLine($"Cliente ID: {Id}, Nome: {Nome}, Idade: {Idade}");
        }
    }
}
