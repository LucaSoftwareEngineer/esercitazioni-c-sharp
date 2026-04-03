using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace EsercitazioniCS.LeCollections
{
    internal class IDictionary
    {
        public IDictionary()
        {

            //coppie chiave-valore, sono fortemente tipizzate, accettano solo elementi dello stesso tipo
            Dictionary<int, string> dizionario = new Dictionary<int, string>();
            dizionario.Add(1, "uno");
            dizionario.Add(2, "due");

            dizionario.ContainsKey(3);

            foreach (var item in dizionario)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
            }

            foreach (KeyValuePair<int, string> item in dizionario)
            {
                Console.WriteLine("chiave: " + item.Key);
                Console.WriteLine("valore: " + item.Value);
            }
        }
    }
}
