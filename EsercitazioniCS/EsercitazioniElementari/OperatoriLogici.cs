using System;
using System.Collections.Generic;
using System.Text;

namespace EsercitazioniCS.EsercitazioniElementari
{
    internal class OperatoriLogici
    {
        public OperatoriLogici() { 
        
            bool a = true;
            bool b = false;

            Console.WriteLine(a && b); // AND
            Console.WriteLine(a || b); // OR
            Console.WriteLine(!a); // NOT
            Console.WriteLine(a ^ b); // XOR
            Console.WriteLine(a && !b); // AND con NOT
            Console.WriteLine(a == b); // EQUALS
            Console.WriteLine(a != b); // NOT EQUALS

        }
    }
}
