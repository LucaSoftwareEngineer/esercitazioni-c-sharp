using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace EsercitazioniCS.LeCollections
{
    internal class LeArrayList
    {
        //accettano elementi di diversi tipi, ma non sono fortemente tipizzate
        //non sono più utilizzate, sono state sostituite dalle List<T> che sono fortemente tipizzate
        //hanno una capacità iniziale di 4 elementi, ma possono crescere dinamicamente se necessario

        public LeArrayList() {
        
            ArrayList arrayList = new ArrayList();
            arrayList.Add("Pippo");
            arrayList.Add(42);

            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }

            ArrayList arrayList2 = new ArrayList()
            {
                2, "Mario", true
            };

            int[] arrayInteri = { 1, 2, 3, 4, 5 };
            arrayList2.AddRange(arrayInteri); //aggiunge tutti gli elementi dell'array all'ArrayList
            arrayList2.Insert(1, "Luigi"); //inserisce un elemento in una posizione specifica

            //Add() aggiunge in coda
            //Insert() aggiunge in una posizione specifica, spostando gli elementi successivi di una posizione

            arrayList2[1] = "Peach"; //modifica l'elemento in posizione 1

            arrayList2.Remove(2); //rimuove la prima occorrenza dell'elemento 2
            arrayList2.RemoveRange(1, 3); //rimuove un intervallo di elementi a partire da una posizione specifica (1) e per un numero specifico di elementi (3)

            foreach (var item in arrayList2)
            {
                Console.WriteLine(item);
            }

            arrayList2.Add("Mario");

            bool check = arrayList2.Contains("Mario"); //verifica se l'ArrayList contiene un elemento specifico
            Console.WriteLine("Contiene Mario? " + check);

            //in c# tutto è object
            //var permette allo sviluppatore delegare al compilatore di identificare il tipo di dato in fase di compilazione, ma non è un tipo di dato vero e proprio

        }
    }
}
