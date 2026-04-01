using System;
using System.Collections.Generic;
using System.Text;

namespace EsercitazioniCS.EsercitazioniElementari
{
    internal class Casting
    {
        public void EsempioCasting()
        {
            //casting implicito
            int prova = 345;
            long prova2 = prova;
            Console.WriteLine(prova);
            Console.WriteLine(prova2);

            //casting esplicito
            long test = 5000;
            int test2 = (int)test;
            Console.WriteLine(test);
            Console.WriteLine(test2);

            //metodi di conversione, mediante oggetto Convert
            int numero = 23;
            string stringa = Convert.ToString(numero);
        }
    }
}
