

using CSVM;
using System;
using System.Diagnostics;
using System.Xml.Linq;
using ClassLibrary1;
using System.CodeDom;
using System.IO;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var c = new Calcolatrice();
            try
            {
                int divisione = c.GetDivisione();
                Console.WriteLine(divisione);
                Console.WriteLine("divisione finita");
            }
            catch (Exception ex)
            {
                Console.WriteLine("sono andato in errore");
                using(var sw = new StreamWriter("C:\\Users\\Valerio\\Source\\Repos\\ConsoleApp7\\error.log", true))
                {
                    sw.WriteLine(DateTime.Now.ToLongTimeString());
                    sw.WriteLine(ex.Message);
                    sw.WriteLine(ex.StackTrace);
                }
            }
            
            Console.ReadLine();
        }
    }   
}