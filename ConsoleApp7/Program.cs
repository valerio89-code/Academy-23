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
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3 };
            var cliente = new Cliente();
            Banca b = new Banca("banca sella")
            {
                Nome = "monte dei paschi"
            };

            Banca b = new Banca("banca sella");
            b.Nome = "monte dei paschi";

            Console.WriteLine(b.Nome);

            b = null;

            GC.Collect();
            GC.WaitForPendingFinalizers();

            var a = 10;
            Console.ReadLine();
        }
    }
}