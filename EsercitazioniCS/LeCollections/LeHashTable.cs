using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace EsercitazioniCS.LeCollections
{
    internal class LeHashTable
    {
        public LeHashTable() {

            //coppie chiave-valore, non sono fortemente tipizzate, accettano elementi di diversi tipi
            Hashtable hashTable = new Hashtable();
            hashTable.Add("chiave", "valore");
            hashTable.Add(1, "uno");

            foreach (var item in hashTable.Keys)
            {
                Console.WriteLine("chiave: " + item);
                Console.WriteLine("valore: " + hashTable[item]);
            }

            foreach (DictionaryEntry item in hashTable)
            {
                Console.WriteLine("chiave: " + item.Key);
                Console.WriteLine("valore: " + item.Value);
            }
        }
    }
}
