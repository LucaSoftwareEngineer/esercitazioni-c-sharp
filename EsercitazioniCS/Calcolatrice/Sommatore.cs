using System;
using System.Collections.Generic;
using System.Text;

namespace EsercitazioniCS.Calcolatrice
{
    internal class Sommatore
    {
        public Sommatore()
        {
            Console.WriteLine("Inserisci il primo numero:");
            int numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Inserisci il secondo numero:");
            int numero2 = Convert.ToInt32(Console.ReadLine());
            int risultato = numero1 + numero2;
            Console.WriteLine($"La somma di {numero1} e {numero2} è: {risultato}");
        }
    }
}
