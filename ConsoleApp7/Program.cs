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

namespace ConsoleApp7
{

    internal static class Program
    {
        static void Main(string[] args)
        {
            var campColosseo = new Campanello() { Name = "colosseo" };
            var campDuomo = new Campanello() { Name = "duomo di milano" };
            var campCasaValerio = new Campanello() { Name = "casa di valerio" };

            var l1 = new Ladro() { Nome = "michele", Specialità  = "serrature"};
            var l2 = new Ladro() { Nome = "luca", Specialità = "casseforti" };
            var l3 = new Ladro() { Nome = "gianna", Specialità = "scassinature" };

            campDuomo.RingPressed += l1.CheckPorta;
            campDuomo.RingPressed += l2.CheckPorta;

            campColosseo.RingPressed += l3.CheckPorta;



            campColosseo.OnRingPressed();
            campDuomo.OnRingPressed();
            campCasaValerio.OnRingPressed();


        }
    }
}