using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo.E2
{
    //Criação da classe funcionário que herda de pessoa
    public class Funcionario : Pessoa
    {
        //Criado um atributo a mais "Cargo", pois essa pessoa precisa de um cargo
        public string Cargo { get; set; }

        //Construtor da classe funcionário, passando o cargo também agora e utilizando o construtor da base que é a pessoa, agora que tem um argumento a mais, fiquei confuso em
        //relação ao construtor, pode me explicar?
        public Funcionario(string nome, int idade, string cargo) : base(nome, idade) 
        {
            Cargo = cargo;
        }

        //Implementação do método abstrato
        public override void MostrarDetalhes()
        {
            Console.WriteLine($"Funcionário: {Nome}, Idadade: {Idade}, Cargo: {Cargo}");
        }
    }
}
