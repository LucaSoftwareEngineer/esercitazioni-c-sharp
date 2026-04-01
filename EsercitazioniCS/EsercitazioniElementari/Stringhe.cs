using System;
using System.Collections.Generic;
using System.Text;

namespace EsercitazioniCS.EsercitazioniElementari
{
    internal class Stringhe
    {
        public Stringhe() {
            //lavorare con le stringhe
            string saluto = "Ciao \"luca\""; //Output: Ciao "luca"
            Console.WriteLine(saluto);

            saluto = "Ciao \nLuca"; //Output: Ciao (a capo) Luca
            Console.WriteLine(saluto);
        }
    }
}
