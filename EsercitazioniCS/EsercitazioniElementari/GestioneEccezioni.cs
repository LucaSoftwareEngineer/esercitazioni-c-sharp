using System;
using System.Collections.Generic;
using System.Text;

namespace EsercitazioniCS.EsercitazioniElementari
{
    internal class GestioneEccezioni
    {
        public GestioneEccezioni()
        {
            string numero1 = "11";

            try
            {
                int num1 = int.Parse(numero1);
                Console.WriteLine($"Il numero convertito è: {num1}");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("il numero è null");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("il numero non è in un formato valido");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("il numero è troppo grande o troppo piccolo per essere rappresentato come int");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Si è verificato un errore: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Operazione di conversione completata.");
            }
        }
    }
}
