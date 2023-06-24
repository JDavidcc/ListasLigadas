using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colas
{
    //implementacion basada en lista ligada
    class Colas
    {
        //es el ancla o encabezado de la cola
        CNodo ancla;

        //Esta variable de referencia nos ayuda trabajar con la cola
        CNodo trabajo;

        public Colas()
        {
            //instanciamos el ancla
            ancla = new CNodo();

            //como es una cola vacia su siguiente es null
            ancla.Siguiente = null;
        }
        //Recorre la cola
        public void Transversa()
        {
            trabajo = ancla;
            
            //Recorre hasta encontrar el final
            while (trabajo.Siguiente != null)
            {
                //avanzamos trabajo
                trabajo=trabajo.Siguiente;
                //obten el dato y lo muestra
                int d = trabajo.Dato;
                Console.Write("<- {0} ", d);
            }
            Console.WriteLine();
        }

        public void Enqueue(int pDato)
        {
            trabajo=ancla;

            //recorre hasta encontral el final
            while(trabajo.Siguiente != null)
            {
                //avanza trabajo
                trabajo = trabajo.Siguiente;
            }

            //Creamos el nuevo nodo
            CNodo temp=new CNodo();

            //Insertamos el dato
            temp.Dato = pDato;

            //Finaliza correctamente
            temp.Siguiente = null;

            //liga el ultimo nodo encontrado con el recien creado
            trabajo.Siguiente = temp;
        }

        public int SalirCola()
        {
            int valor = 0;

            //llevamos a cabo el trabajo solo si hay elementos en la cola
            if (ancla.Siguiente!=null)
            {
                //obtenemos el dato correspondiente
                trabajo = ancla.Siguiente;
                valor= trabajo.Dato;

                //Sale de la cola
                ancla.Siguiente = trabajo.Siguiente;
                trabajo.Siguiente = null;
            }
            return valor;
        }
        //peek
        public int Peek()
        {
            int valor = 0;

            //llevamos a cabo el trabajo solo si hay elementos en la cola
            if (ancla.Siguiente!=null)
            {
                //obten el dato correspondiente
                trabajo= ancla.Siguiente;
                valor= trabajo.Dato;
            }
            return valor;
        }
        
    }
}
