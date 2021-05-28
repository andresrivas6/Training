using System;
using System.Collections.Generic;
using System.Text;

namespace Training
{
    public class Conversor
    {
        public string decimalToBinario()
        {
            string aux = "";
            Console.WriteLine("Escriba el numero a conevrtir: ");
            int numAux = Int32.Parse(Console.ReadLine());
            while (numAux >= 2)
            {
                aux = (numAux % 2).ToString() + aux;
                Console.WriteLine("la primera vez el mod es: "+aux);
                numAux = numAux / 2;
            }
            aux = (numAux % 2).ToString() + aux;
            return aux;
        }
    }
}
