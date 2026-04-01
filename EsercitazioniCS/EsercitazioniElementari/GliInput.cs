using System;
using System.Collections.Generic;
using System.Text;

namespace EsercitazioniCS.EsercitazioniElementari
{
    internal class GliInput
    {
        public GliInput()
        {
            Console.WriteLine("Inserisci un numero:");
            int numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Hai inserito: {numero}");
        }
    }
}
