using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo.E2
{
    public abstract class Pessoa<T> : IEntidade<T>
    {
        public T Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }

        protected Pessoa(T id, string nome, int idade)
        {
            Id = id;
            Nome = nome;
            Idade = idade;
        }

        public abstract void MostrarDetalhes();
    }
}
