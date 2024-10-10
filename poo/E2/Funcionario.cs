using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo.E2
{
    public class Funcionario : Pessoa<int>
    {
        public string Cargo { get; private set; }

        public Funcionario(int id, string nome, int idade, string cargo) : base(id, nome, idade)
        {
            Cargo = cargo;
        }

        public override void MostrarDetalhes()
        {
            Console.WriteLine($"Funcionário ID: {Id}, Nome: {Nome}, Idade: {Idade}, Cargo: {Cargo}");
        }
    }
}
