using System;
using System.Collections.Generic;
using System.Text;

namespace EsercitazioniCS.EsercitazioniElementari
{
    internal class Variabili
    {
        const string nome = "Luca";
        int eta = 23;

        string testo = "lorem ipsum dolor sit amet";
        char carattere = 'a';
        int numeroIntero = 42;
        long numeroLungo = 1234567890123456789;
        double numeroDecimale = 3.14;
        float numeroConVirgolaMobile = 2.71828f;
        bool variabileBooleana = true;

        public void Stampa()
        {
            Console.WriteLine("Ciao " + nome + " " + eta + "enne ");
            //formattazione stringhe
            Console.WriteLine("Ciao {0} hai {1} anni", nome, eta);
            Console.WriteLine("Ciao {1} hai {0} anni", nome, eta);
            Console.WriteLine($"Ciao {nome} hai {eta} anni");
        }
    }
}
