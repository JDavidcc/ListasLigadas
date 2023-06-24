using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colas
{
    class CNodo
    {
        //aqui guarda datos el nodo
        private int dato;
        //sig nodo
        private CNodo siguiente = null;

        //propiedades
        public int Dato { get => dato; set => dato = value; }
        internal CNodo Siguiente { get => siguiente; set => siguiente = value; }

        //imprimir
        public override string ToString()
        {
            return string.Format("[{0}]", dato);
        }
    }

}
