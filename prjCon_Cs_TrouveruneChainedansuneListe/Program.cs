using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjCon_Cs_TrouveruneChainedansuneListe
{
   /*
    * This project uses the following licenses:
    *  MIT License
    *  Copyright (c) 2019 Ricardo Mendoza 
    *  Montréal Québec Canada
    *  Institut Teccart
    *  www.teccart.qc.ca
    *  Hiver 2019
    */
    class Program
    {
        static void Main(string[] args)
        {
            // variable 
            string liste = "ABCABCABCCCBAB";
            string xchaine = "A";
            string ychaine = "C";
            Console.WriteLine("\n\n TROUVER UNE CHAINE DANS UNE LISTE", Console.ForegroundColor=ConsoleColor.Green);
            Console.WriteLine("\n\nResultat : " + fncTrouveruneChaine(liste, xchaine), Console.ForegroundColor=ConsoleColor.Yellow);
            Console.WriteLine("\nResultat : " + fncTrouveruneChaine(liste, ychaine),Console.ForegroundColor=ConsoleColor.Gray);
            Console.ReadKey();
        }

        // Trouver une chaine dans une liste
        // staic -> methods are methods that are called on the class itself, not on specific object instance
        // private -> the method can be acceced only by code in the same class or struct
        private static string fncTrouveruneChaine(string liste, string findChaine)
        {
            // Contains->returns a value indicating wheter a specified substring occurs withing this string
            bool result = liste.Contains(findChaine);
            if (result)
            {
                return findChaine;
            }
            else
            {
                return "chaine non trouve";
            }
        }
    }
}