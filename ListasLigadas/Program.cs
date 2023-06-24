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
            miLista.Adicionar(5);
            miLista.Adicionar(7);
            miLista.Adicionar(9);
            miLista.Adicionar(11);
            miLista.Adicionar(15);

            miLista.Transversa();

            Console.WriteLine(miLista.BuscarAnterior(123));

            //Console.WriteLine(miLista.BuscarIndice(9));

            //Console.WriteLine(miLista.EstaVacio());

            //miLista.Vaciar();

            //miLista.Transversa();
            //Console.WriteLine(miLista.EstaVacio());

            //CNodo encontrado = miLista.Buscar(17);
            //Console.WriteLine(encontrado);

        }
    }
}
