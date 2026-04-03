using System;
using System.Collections.Generic;
using System.Text;

namespace EsercitazioniCS.LeCollections
{
    internal class Stack
    {
        public Stack() {

            //Stack è una struttura dati che segue il principio LIFO (Last In First Out), l'ultimo elemento inserito è il primo ad essere rimosso
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Pop();

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            //se voglio vedere la cima uso il metodo Peek(), che restituisce l'elemento in cima senza rimuoverlo
            Console.WriteLine(stack.Peek());

        }
    }
}
