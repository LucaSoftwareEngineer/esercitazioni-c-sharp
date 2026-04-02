using System;
using System.Collections.Generic;
using System.Text;

namespace EsercitazioniCS.EsercitazioniElementari
{
    public class Array
    {
        public static void ese()
        {
            string[] nomi = new string[3];
            nomi[0] = "Mario";
            nomi[1] = "Luigi";
            nomi[2] = "Peach";

            int[] numeri = { 1, 2, 3, 4, 5 };

            string[,] matrice = new string[3, 2] //numero righe, numero colonne
            {
                { "Mario", "Rossi"  },
                { "Luigi", "Verdi" },
                { "Peach", "Gialli" }
            };

            for (int i = 0; i < matrice.GetLength(0); i++)
            {
                for (int j = 0; j < matrice.GetLength(1); j++)
                {
                    Console.Write(matrice[i, j] + " ");
                }
                Console.WriteLine();
            }

            //array irregolari
            int[][] arrayIrregolare =
            {
                new int[] { 1, 2, 3, 4},
                new int[] { 5, 6 },
                new int[] { 7, 8, 9 }
            };

            for (int i = 0; i < arrayIrregolare.Length; i++)
            {
                for (int j = 0; j < arrayIrregolare[i].Length; j++)
                {
                    Console.Write(arrayIrregolare[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
