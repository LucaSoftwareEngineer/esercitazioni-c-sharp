using EsercitazioniCS.Calcolatrice;
using EsercitazioniCS.LeCollections;
using EsercitazioniCS.OrientedObject;
using System;

namespace EsercitazioniCS
{
    class Program
    {
        static void Main(string[] args)
        {
            //GliInput input = new GliInput();ù
            //Sommatore sommatore = new Sommatore();
            //GestioneEccezioni ex = new GestioneEccezioni();
            //OperatoriLogici operatoriLogici = new OperatoriLogici();
            //CondizioniAndCicli condizioniAndCicli = new CondizioniAndCicli();
            //Metodi.Saluta();
            //Metodi.Somma(1, 2);
            //Metodi.Somma(1, 2, 3);
            //EsercitazioniElementari.Array.ese();
            //LeArrayList leArrayList = new LeArrayList();
            //LeListe leListe = new LeListe();
            //LeHashTable leHashTable = new LeHashTable();
            //IDictionary iDictionary = new IDictionary();
            //LeCollections.Stack stack = new LeCollections.Stack();
            LeQueue leQueue = new LeQueue();

            //nota: il metodo Clear svuota la collezione

            Persona p1 = new Persona("Mario");
            p1.Saluta();

            Persona p2 = new Persona("Luigi", "Verdi");
            p2.Saluta();

        }
    }
}
