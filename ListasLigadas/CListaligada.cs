using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Listas
{
    class CListaligada
    {

        private CNodo ancla;

        private CNodo trabajo;

        private CNodo trabajo2;

        public CListaligada()
        {
            ancla = new CNodo();

            ancla.Siguiente = null;
        }
        
        //recorelista
        public void Transversa()
        {
            trabajo = ancla;

            while (trabajo.Siguiente != null)
            {
                trabajo=trabajo.Siguiente;
                int d = trabajo.Dato;

                Console.Write("{0}, ", d);

            }
            //bajar linea
            Console.WriteLine();
        }
        //Adicion nuevo elemento

        public void Adicionar (int pDato)
        {

            trabajo=ancla;

            //recorre lista hasta el final
            while (trabajo.Siguiente !=null)
            {
                //avanzar trabajo
                trabajo = trabajo.Siguiente;
            }
            //nuevo nodo
            CNodo temp = new CNodo();

            //insertamos dato
            temp.Dato = pDato;

            //finalizamos
            temp.Siguiente = null;

            //ligar ultimo nodo encontrado con el recien creado
            trabajo.Siguiente = temp;
        }
        //Vacia la lista
        public void Vaciar()
        {
            ancla.Siguiente = null;
        }

        //verifica vacio
        public bool EstaVacio()
        {
            if (ancla.Siguiente == null)
                return true;
            else 
                return false;
        }

        //regresa el nodo con la primera ocurriencia del dato
        public CNodo Buscar(int pDato)
        {
            if (EstaVacio() == true)
                return null;

            trabajo2 = ancla;

            //recorremos para ver si lo encuentra
            while (trabajo2.Siguiente!=null)
            {
                trabajo2 = trabajo2.Siguiente;
                //si lo encuentra lo regresa
                if (trabajo2.Dato == pDato)
                    return trabajo2;

            }
            //no se encuentra
            return null;
        }

        //Bucar indice donde se encuentra la primera ocurrencia del dato
        public int BuscarIndice(int pDato)
        {
            int n = -1;

            trabajo=ancla;
            while (trabajo.Siguiente!=null)
            {
                trabajo = trabajo.Siguiente;
                n++;

                if(trabajo.Dato==pDato)
                    return n;
            }

            return -1;
        }

        //Encuentra al nodo anterior
        //Si esta en el primer nodo se regresa el "ancla"
        //si el dato no existe se regresa el ultimo nodo
        public CNodo BuscarAnterior(int pDato)
        {
            
            trabajo2=ancla;

            while (trabajo2.Siguiente!=null && trabajo2.Siguiente.Dato!= pDato)
                trabajo2=trabajo2.Siguiente;
            return trabajo2;

        }

    }
}
