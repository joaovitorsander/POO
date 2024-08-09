using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo.E2
{
    public class Funcionario : Pessoa
    {
        public string Cargo { get; set; }

        public Funcionario(string nome, int idade, string cargo) : base(nome, idade) 
        {
            Cargo = cargo;
        }

        public override void MostrarDetalhes()
        {
            Console.WriteLine($"Funcionário: {Nome}, Idadade: {Idade}, Cargo: {Cargo}");
        }
    }
}
