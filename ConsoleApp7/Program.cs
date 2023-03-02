using System;
using System.Diagnostics;
using System.Xml.Linq;
using ClassLibrary1;
using System.CodeDom;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Collections;
using System.Linq.Expressions;
using System.Threading;

namespace ConsoleApp7
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            //n! 5 1*2*3*4*5
            //Fact(5)
            Console.WriteLine(Fact(5));
        }

        public static int Fact(int n)
        {
            //caso base
            if (n == 1) return 1;
            return n * Fact(n - 1);
        }

    }
}