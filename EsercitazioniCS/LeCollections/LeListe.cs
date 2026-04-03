using System;
using System.Collections.Generic;
using System.Text;

namespace EsercitazioniCS.LeCollections
{
    internal class LeListe
    {

        public LeListe() { 
        
            List<int> lista = new List<int>() { 1,2,3};
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }

            lista.RemoveAt(0);

            //le liste sono dinamiche, possono crescere e diminuire in base alle esigenze
            //le liste sono fortemente tipizzate, accettano solo elementi dello stesso tipo

        }

    }
}
