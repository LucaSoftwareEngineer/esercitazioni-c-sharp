using System;
using System.Collections.Generic;
using System.Text;

namespace EsercitazioniCS.OrientedObject
{
    internal class Persona
    {
        public string Name { get; set; }
        public void Saluta()
        {
            Console.WriteLine("Ciao, mi chiamo " + Name);
        }
    }
}
