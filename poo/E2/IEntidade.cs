using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo.E2
{
    // Interface genérica para definir um contrato comum para entidades, aplicando o princípio de abstração (SOLID).
    public interface IEntidade<T>
    {
        T Id { get; set; }
        string Nome { get; set; }
        void MostrarDetalhes();
    }
}