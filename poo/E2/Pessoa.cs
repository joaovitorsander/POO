using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo.E2
{
    //Criação da classe pessoa que implementa uma interface "IEntidade"
    //Dessa forma, ela precisa ter o atributo "Nome" e o método "MostrarDetalhes"
    //Isso que vou falar não tenho certeza, estou chutando, é o que eu acho. abstract quer dizer que, por exemplo, o método "MostrarDetalhes" precisa ser implementado
    //pelas classes que vão herdar a pessoa. Mas eu não entendi a parte "public abstract class Pessoa"
    public abstract class Pessoa : IEntidade
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        //Construtor da classe pessoa.
        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        public abstract void MostrarDetalhes();
    }
}
