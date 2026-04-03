using System;
using System.Collections.Generic;
using System.Text;

namespace EsercitazioniCS.LeCollections
{
    internal class LeQueue
    {
        public LeQueue() {

            //struttura dati che segue il principio FIFO (First In First Out), il primo elemento inserito è il primo ad essere rimosso

            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Mario");
            queue.Enqueue("Luigi");
            queue.Enqueue("Peach");

            queue.Dequeue(); //rimuove l'elemento in testa alla coda e lo restituisce

            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

        }
    }
}
