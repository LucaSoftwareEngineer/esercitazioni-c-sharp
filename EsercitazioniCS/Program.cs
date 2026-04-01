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

            //casting implicito
            int prova = 345;
            long prova2 = prova;
            Console.WriteLine(prova);
            Console.WriteLine(prova2);

            //casting esplicito
            long test = 5000;
            int test2 = (int) test;
            Console.WriteLine(test);
            Console.WriteLine(test2);

            //metodi di conversione, mediante oggetto Convert
            int numero = 23;
            string stringa = Convert.ToString(numero);

            //lavorare con le stringhe
            string saluto = "Ciao \"luca\""; //Output: Ciao "luca"
            Console.WriteLine(saluto);

            saluto = "Ciao \nLuca"; //Output: Ciao (a capo) Luca
            Console.WriteLine(saluto);

            //formattazione stringhe
            Console.WriteLine("Ciao {0} hai {1} anni", nome, eta);
            Console.WriteLine("Ciao {1} hai {0} anni", nome, eta);
            Console.WriteLine($"Ciao {nome} hai {eta} anni");

            Console.WriteLine("Ciao " + nome + " " + eta + "enne ");
            Console.Read();
        }
    }
}
