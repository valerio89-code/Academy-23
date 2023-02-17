using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        //fare un applicazione che gestisca un ecommerce di libri
        /*
         Account che definisce uno user account {getOrdini, compra}
         Carrello che definisce un carrello {aggiungi libro, rimuovi libro, getTotale}
         Libro che definisce un elemento {}
         Autore che definisce l'autore di un libro {}
         Ordine {}
         
         */
        static void Main(string[] args)
        {
            var arrOut = new int[] { 1, 2, 34 };
            int result = Helper.Somma(arrOut);
            Helper.Somma(1, 2);
            Console.WriteLine(Helper.Somma(1, 2, 34, 2, 3, 5, 2, 2, 45));
            Console.WriteLine(result);
            Console.WriteLine(arrOut[2]);
            Console.ReadLine();
        }
    }

    public class Helper
    {
        public static int Somma(params int[] arr)
        {
            arr[2] = 100;
            int somma = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                somma += arr[i];
            }
            return somma;
        }

        public static Persona ChangeNome(Persona p = null)
        {
            //Persona p = p1
            p = new Persona();
            p.Nome = "NOME CAMBIATO";
            return p;
        }
    }

    public class Calcolatrice
    {
        public const int defaultValue = 10;
        public readonly int years = DateTime.Now.Year;

        public static string GetNome(Persona p = null)
        //Persona p = p2
        {
            p = new Persona();
            return p.Nome;
        }

        public static string DoNothing(string n1)
        {
            return n1;
        }
        public static int DoNothing(int n1)
        {
            return n1;
        }

        public static int Somma(int n1, int n2, int n3 = defaultValue)
        {
            return n1 + n2 + n3;
        }
    }
}