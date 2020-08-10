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
    *  ÉTE 2020
    */
    class Program
    {
        static void Main(string[] args)
        {
            // variable 
            string liste = "ABCABCABCCCBAB";
            string xchaine = "ABC";
            string ychaine = "CCC";
            string list;
            string zchaine;
            char end;

            Console.WriteLine("\n\n TROUVER UNE CHAINE DANS UNE LISTE", Console.ForegroundColor=ConsoleColor.Green);
            Console.WriteLine("\n\n LISTE : ABCABCABCCCBAB", Console.ForegroundColor = ConsoleColor.Green);
            Console.WriteLine("\n\nResultat : " + fncTrouveruneChaine(liste, xchaine), Console.ForegroundColor = ConsoleColor.Yellow);
            Console.WriteLine("\nResultat : " + fncTrouveruneChaine(liste, ychaine), Console.ForegroundColor = ConsoleColor.Gray);
            Console.ReadKey();
            try
            {
                Console.WriteLine("\nWrite the list -> \n", Console.ForegroundColor = ConsoleColor.Green);
                list = Convert.ToString(Console.ReadLine().ToUpper());
                Console.WriteLine("\n The List -> " + list);
                do
                {
                    Console.WriteLine("\nWrite the chine -> \n", Console.ForegroundColor=ConsoleColor.Yellow);
                    zchaine = Convert.ToString(Console.ReadLine().ToUpper());
                    Console.WriteLine("\n\nResultat : " + fncTrouveruneChaine(list, zchaine), Console.ForegroundColor = ConsoleColor.Yellow);

                    Console.WriteLine("\nContinue [Y/N]");
                    end = char.Parse(Console.ReadLine().ToUpper());
                }
                while (end == 'Y');
            }
            catch(Exception e)
            {
                Console.WriteLine("error in program : " + e.Message);
            }
            finally
            {
                /* A common usage of catch and finally together is to obtain and use resources in a try block */
                /* deal with exceptional circumstances in a catch block, and release the resources in the finally block. */

                // To run the program in Visual Studio, type CTRL+F5. Then
                // click Cancel in the error dialog.
                Console.WriteLine("\nExecution of the finally block after an unhandled\n" +
                    "error depends on how the exception unwind operation is triggered.", Console.ForegroundColor=ConsoleColor.Gray);
            }
            Console.ReadLine();
        }
        // Trouver une chaine dans une liste
        // staic -> methods are methods that are called on the class itself, not on specific object instance
        // private -> the method can be acceced only by code in the same class or struct
        private static string fncTrouveruneChaine(string liste, string findChaine)
        {
            bool result = liste.Contains(findChaine); /* Contains->returns a value indicating wheter a specified substring occurs withing this string */
                                                      /* using the specified comparison rules. */
            if (result)
            {
                return findChaine; /* true if the value parameter occurs within this string; otherwise, false. */
            }
            else
            {
                return "chaine non trouve";
            }
        }
    }
}