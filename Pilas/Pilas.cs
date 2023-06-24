using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilas
{
    internal class Pila
    {
        //encabezado de la pila
        private CNodo ancla;

        //esta variable de referencia nos ayuda a trabajar con el stack
        private CNodo trabajo;

        public Pila()
        {
            //instanciamos el ancla
            ancla = new CNodo();

            //como es un stack vacio su siguiente es null
            ancla.Siguiente = null;

        }

        //Push
        public void Push (int pDato)
        {
            //creamos el nodo temporal
            CNodo temp = new CNodo();
            temp.Dato = pDato;

            //conectamos el temporal a la lista
            temp.Siguiente = ancla.Siguiente;

            //conectamos el ancla al temporal
            ancla.Siguiente = temp;

        }
        //Pop
        public int Pop()
        {
            int valor = 0;
            //Llevamos a cabo el trabajo solo si hay elementos en la pila
            if (ancla.Siguiente != null)
            {
                //obtenemos el dato correspondiente
                trabajo = ancla.Siguiente;
                valor = trabajo.Dato;

                //lo sacamos de la pila
                ancla.Siguiente=trabajo.Siguiente;
                trabajo.Siguiente = null;
            }
            return valor;
        }
        //Peek
        public int Peek()
        {
            int valor = 0;

            //Llevamos a cabo el trabajo solo si hay elementos en la pila
            if(ancla.Siguiente != null)
            {
                //obtenemos el dato correspondiente
                trabajo=ancla.Siguiente;
                valor = trabajo.Dato;
            }
            return valor;
        }
        //Transversa
        public void Transversa()
        {
            trabajo = ancla;
            while (trabajo.Siguiente != null)
            {
                trabajo=trabajo.Siguiente;

                int d = trabajo.Dato;

                Console.WriteLine("[{0}]", d);
            }

        }

    }
}
