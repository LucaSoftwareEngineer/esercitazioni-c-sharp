using System;

namespace EsercitazioniCS
{
    class Program
    {
        static void Main(string[] args)
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

            Console.WriteLine("Ciao " + nome + " " + eta + "enne ");
            Console.Read();
        }
    }
}
