using System;
using System.Collections.Generic;
using System.Text;

namespace EsercitazioniCS.OrientedObject
{
    internal class Persona
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public Persona(string name)
        {
            Name = name;
        }

        public Persona(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        public void Saluta()
        {
            if (Surname == null)
            {
                Console.WriteLine("Ciao, mi chiamo " + Name);
            }
            else
            {
                Console.WriteLine("Ciao, mi chiamo " + Name + " " + Surname);
            }
        }
    }
}
