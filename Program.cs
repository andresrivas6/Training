using System;

namespace Training
{
    class Program
    {
        static void Main(string[] args)
        {

            Conversor con = new Conversor();

            Console.WriteLine("El numero en binario es: "+ con.decimalToBinario());

            //pidePalabra();
            
            /*
            ArbolBinario arbol = new ArbolBinario();

            NodoArbol raiz = arbol.Insertar(20, null);
            arbol.Insertar(18, raiz);
            arbol.Insertar(10, raiz);
            arbol.Insertar(5, raiz);
            arbol.Insertar(15,raiz);
            arbol.Insertar(14, raiz);
            arbol.Insertar(17, raiz);
            arbol.Insertar(13, raiz);

            Ordenamiento o = new Ordenamiento();

            Console.WriteLine("El numero de nodos son: {0}", o.cuentaNodos(raiz, 0));
            */

            /*arbol.Insertar(7, raiz);
            arbol.Insertar(11, raiz);
            arbol.Insertar(9, raiz);
            arbol.Insertar(10, raiz);
            arbol.Insertar(0, raiz);
            arbol.Insertar(-1, raiz);
            arbol.Insertar(12, raiz);
            arbol.Insertar(14, raiz);
            */
            /*
            arbol.Transversa(raiz);

            NodoArbol raizN = arbol.BorrarNodo(raiz, 10);
            Console.WriteLine("--------------------------");
            Console.WriteLine("El nuevo Arbol es: ");
            Console.WriteLine("--------------------------");
            arbol.Transversa(raizN);

            */
            /*
            Console.WriteLine("El numero minimo es: {0}", arbol.EncuentraMinimo(raiz));
            Console.WriteLine("El numero maximo es: {0}", arbol.EncuentraMaximo(raiz));
            
            arbol.TransversaOrdenada(raiz);
            Console.WriteLine();

            NodoArbol temp = arbol.EncuentraNodoMinimo(raiz);
            Console.WriteLine("El dato del nodo menor es: {0}", temp.dato);

            temp = arbol.EncuentraNodoMaximo(raiz);
            Console.WriteLine("El dato del nodo mayor es: {0}", temp.dato);
            */

            //Console.WriteLine("---------------");
            //NodoArbol padre = arbol.BuscarPadre(11,raiz);
            //Console.WriteLine("El padre de 11 es: {0}", padre.dato);


        }

        static void pideNumero()
        {
            bool flag = true;
            do
            {
                Console.WriteLine("Can you type a word");
                string palabra = Console.ReadLine();
                try
                {
                    long num = Convert.ToInt64(palabra);
                    Console.WriteLine("El numero que ingreso es: " + Convert.ToString(num));
                    flag = false;
                }
                catch
                {
                    Console.WriteLine("No es un entero el que ingreso");
                }
            } while (flag);
        }

        static void pidePalabra()
        {
            bool flag = true;
            do
            {
                Console.WriteLine("Estimad@ escriba la palabra que desea saber si es palindroma: ");
                bool palin = false;
                string palabra = Console.ReadLine().ToLower();
                if (palabra == "")
                {
                    flag = false;
                    break;
                }
                    
                //creo la variable del tamanio de la palabra
                char[] pal = new char[palabra.Length];
                pal = palabra.ToCharArray();

                palin = palindroma(pal, palabra.Length-1);

                if (palin)
                    Console.WriteLine("******** ESOOOO ***********\n \t La Palabra es Palindroma");
                else
                    Console.WriteLine("******** ERROR ***********\n \t La Palabra NO es Palindroma");
            } while (flag);

            Console.WriteLine("*********\tGracias por utilizar el metodo\t**************");

        }

        static bool palindroma(char[] palabra, int tam)
        {
            int i = 0;
            
            while (i <= tam)
            {
                if (palabra[i] != palabra[tam])
                    return false;
                i++;
                tam--;
            }
            return true;
        }
    }
}
