using System;
using System.Collections.Generic;
using System.Text;

namespace EsercitazioniCS.EsercitazioniElementari
{
    internal class CondizioniAndCicli
    {
        public CondizioniAndCicli()
        {

            int numero = 10;

            if (numero % 2 == 0)
            {
                Console.WriteLine("Il numero è pari");
            }
            else
            {
                Console.WriteLine("Il numero è dispari");
            }

            Console.WriteLine(numero % 2 == 0 ? "pari" : "dispari");

            switch (numero)
            {
                case 1:
                    Console.WriteLine("Il numero è 1");
                    break;
                default:
                    Console.WriteLine("Il numero non è 1");
                    break;
            }

            int i = 0;
            while (i < 5)
            {
                Console.WriteLine(i);
                i++;
            }

            i = 0;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i < 5);

            for (char j = 'a'; j < 'z' + 1; j++)
            {
                Console.WriteLine(j);
            }

            String[] nomi = { "Mario", "Luigi", "Peach" };
            foreach (String nome in nomi)
            {
                Console.WriteLine(nome);
            }
        }
    }
}
