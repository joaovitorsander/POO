using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace poo.E2
{
    //Criando a classe cliente que herda de pessoa
    public class Cliente : Pessoa
    {
        //Construtor da classe cliente, que precisa ser passado o nome e a idade, eu só não entendi essa parte ": base(nome, idadade)"
        public Cliente(string nome, int idadade) : base(nome, idadade)
        {
        }

        //implementação do método "MostrarDetalhes", que deve ser implementado pela classe filha
        public override void MostrarDetalhes()
        {
            Console.WriteLine($"Cliente: {Nome}, Idade: {Idade}");
        }
    }
}
