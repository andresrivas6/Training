using System;
using System.Collections.Generic;
using System.Text;

namespace Training
{
    class ArbolBinario
    {

        int i = 0;

        public NodoArbol Raiz { get; set; }
        public NodoArbol ayuda { get; set; }

        public NodoArbol Insertar(int pDato, NodoArbol pNodo)
        {
            NodoArbol temp = null;

            if (pNodo == null)
            {
                temp = new NodoArbol();
                temp.dato = pDato;

                return temp;
            }

            if (pDato < pNodo.dato) {
                pNodo.hijoIzq = Insertar(pDato, pNodo.hijoIzq);

            }
            if (pDato > pNodo.dato) {
                pNodo.hijoDer = Insertar(pDato, pNodo.hijoDer);
            }

            return pNodo;
        }

        public void Transversa(NodoArbol pNodo) {
            if (pNodo == null)
                return;

            for (int n = 0; n < i; n++)
                Console.Write("   ");

            Console.WriteLine(pNodo.dato);

            if(pNodo.hijoIzq != null)
            {
                i++;
                Console.Write("I ");
                Transversa(pNodo.hijoIzq);
                i--;
            }

            if(pNodo.hijoDer != null)
            {
                i++;
                Console.Write("D ");
                Transversa(pNodo.hijoDer);
                i--;
            }
        }

        public void TransversaOrdenada(NodoArbol pNodo)
        {
            if (pNodo == null)
                return;
            
            //si tengo a la izq
            if(pNodo.hijoIzq != null)
            {
                i++;
                TransversaOrdenada(pNodo.hijoIzq);
                i--;
            }

            Console.Write("{0}, ",pNodo.dato);

            if (pNodo.hijoDer != null)
            {
                i++;
                TransversaOrdenada(pNodo.hijoDer);
                i--;
            }


        }
        public int EncuentraMinimo(NodoArbol pNodo) {
            if (pNodo == null)
                return 0;

            ayuda = pNodo;
            int minimo = pNodo.dato;

            while(ayuda.hijoIzq != null)
            {
                ayuda = ayuda.hijoIzq;
                minimo = ayuda.dato;
            }

            return minimo;

        }

        public int EncuentraMaximo(NodoArbol pNodo)
        {
            if (pNodo == null)
                return 0;

            ayuda = pNodo;
            int maximo = pNodo.dato;

            while(ayuda.hijoDer != null)
            {
                ayuda = ayuda.hijoDer;
                maximo = ayuda.dato;
            }
            return maximo;
        }

        public NodoArbol EncuentraNodoMinimo(NodoArbol pNodo)
        {
            if (pNodo == null)
                return null;

            ayuda = pNodo;
            int minimo = pNodo.dato;

            while(ayuda.hijoIzq != null)
            {
                ayuda = ayuda.hijoIzq;
                minimo = ayuda.dato;
            }

            return ayuda;
        }

        public NodoArbol EncuentraNodoMaximo(NodoArbol pNodo)
        {
            if (pNodo == null)
                return null;

            ayuda = pNodo;

            while (ayuda.hijoDer != null)
            {
                ayuda = ayuda.hijoDer;
            }

            return ayuda;
        }

        public NodoArbol BuscarPadre(int pDato, NodoArbol pNodo)
        {
            if (pNodo == null)
                return null;

            NodoArbol temp = null;

            //verifico si yo soy el padre del dato
            if (pNodo.hijoIzq != null)
                if (pNodo.hijoIzq.dato == pDato)
                    return pNodo;

            //verifico si no esta a la derecha
            if (pNodo.hijoDer != null)
                if (pNodo.hijoDer.dato == pDato)
                    return pNodo;

            if (pNodo.hijoIzq != null && pDato < pNodo.dato)
                temp = BuscarPadre(pDato, pNodo.hijoIzq);

            if (pNodo.hijoDer != null && pDato > pNodo.dato)
                temp = BuscarPadre(pDato, pNodo.hijoDer);

            return temp;
        }

        public NodoArbol BorrarNodo(NodoArbol pNodo, int pDato)
        {
            if (pNodo == null)
                return null;

            if (pDato < pNodo.dato)
            {
                pNodo.hijoIzq = BorrarNodo(pNodo.hijoIzq, pDato);
                return pNodo;
            }


            if (pDato > pNodo.dato)
            {
                pNodo.hijoDer = BorrarNodo(pNodo.hijoDer, pDato);
                return pNodo;
            }
            else
            {
                //caso que no tenga hijos
                if (pNodo.hijoIzq == null && pNodo.hijoDer == null)
                {
                    pNodo = null;
                    return pNodo;
                }
                //tiene hijo derecho
                else if (pNodo.hijoIzq == null)
                {
                    //NodoArbol padre = BuscarPadre(pDato, pNodo);
                    //if(padre.dato > pNodo.dato)
                    //  padre.hijoIzq = pNodo.hijoDer;
                    //else
                    //  padre.hijoDer = pNodo.hijoDer;

                    return pNodo.hijoDer;
                }
                //tiene hijo izq
                else if (pNodo.hijoDer == null)
                {
                    return pNodo.hijoIzq;
                }
                else
                {
                    //este caso es cuando tiene 2 hijos 
                    NodoArbol minimo = EncuentraNodoMinimo(pNodo.hijoDer);
                    pNodo.dato = minimo.dato;
                    pNodo.hijoDer = BorrarNodo(pNodo.hijoDer, minimo.dato);
                    return pNodo;
                }
            }
        }
    }
}
