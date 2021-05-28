using System;
using System.Collections.Generic;
using System.Text;

namespace Training
{
    public class Ordenamiento
    {
        // ORDENAMIENTO EN PROFUNDIDAD (DEPTH)

        //PreOrder es Raiz, Izq , Derecha 
        public void PreOrden(NodoArbol nodo) {
            if (nodo == null)
            {
                return;
            }

            Console.WriteLine("El nodo tiene valor: " + nodo.dato);
            PreOrden(nodo.hijoIzq);
            PreOrden(nodo.hijoDer);

            
        }

        //PosOrden es Izq, Derecha, Raiz
        public void PosOrden(NodoArbol nodo) { 
            if (nodo == null)
            {
                return;
            }

            PosOrden(nodo.hijoIzq);
            PosOrden(nodo.hijoDer);

            Console.WriteLine("El nodo tiene valor: " + nodo.dato);
        }

        //InOrden es Izq, Raiz, Derecha
        public void InOrdenamiento(NodoArbol nodo)
        {
            if (nodo == null)
            {
                return;
            }

            InOrdenamiento(nodo.hijoIzq);
            Console.WriteLine("El nodo tiene valor: " + nodo.dato);
            InOrdenamiento(nodo.hijoDer);
        }

        public int cuentaNodos(NodoArbol pNodo, int cant) {
            if (pNodo == null)
                return cant;

            cant++;
            if (pNodo.hijoIzq != null)
                cant = cuentaNodos(pNodo.hijoIzq, cant);
            
            if (pNodo.hijoDer != null)
                cant = cuentaNodos(pNodo.hijoDer, cant);


            return cant;
        }

    }
}
