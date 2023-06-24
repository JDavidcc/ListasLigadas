using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            CListaligada miLista = new CListaligada();

            miLista.Adicionar(3);
            miLista.Adicionar(4);
            miLista.Adicionar(2);
            miLista.Adicionar(1);

            miLista.Transversa();
        }
    }
}
