using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo.E2
{
    public interface IEntidade
    {
        string Nome { get; set; }
        void MostrarDetalhes();
    }
}
