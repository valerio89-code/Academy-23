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
    {/*
variabili e tipi di dato
.NET framework
for forreach while - stack vs heap
if switch for foreach - stack heap
introduzione oop, attributi e metodi, incapsulamento
classi costruttori distruttori metodi. Dettaglio metodi (ref out, params..)
liste e metodi delle liste. 
**Linq to object.
Accenno tdd genercis T
ereditaerità, metodi LINQ
accenno polimorfismo
polimorfismo, enum, operatore ternario, **null coalescing, null propagator
interfacce, streamreader stream writer
classi statiche, singleton, 
**eccezioni
abstract, sealed
windows form, delegates, events, dictionary, arraylist, file
delegates e events, xml, json, serialize, windows forms, file, generics, partial classes. dictionary
unit test, solid principles, tdd e designpatterns
multithreading ricorsione
*/
        static void Main(string[] args)
        {
            var path = "C:\\Users\\Valerio\\Source\\Repos\\ConsoleApp7\\FileStudenti.xml";
            XElement studenti = XElement.Load(path);
            var a = studenti.Descendants().Where(x => x.Name == "Voto")
                .Select(x => int.Parse(x.Value)).Average();

        }
    }

    public class Database
    {
        public Persona GetPersona(string nome)
        {
            //chiamata al database
            var result = FakeCall(nome);
            if (result != null)
            {
                return new Persona() { Nome = nome };
            }
            else
            {
                return null;
            }
        }

        public object FakeCall(string nome)
        {
            return new object(); ;
        }
    }

    public class Persona
    {
        public string Nome { get; set; }

        public string GetNomeLower()
        {
            var sw = new StreamReader("C:\\Users\\Valerio\\Source\\Repos\\WinFormsApp2\\listanomi.csv");
            try
            {
                return Helper.GetStringToLower(null);
            }
            finally
            {
                sw.Dispose();
            }

            return null;

        }
    }

    public static class Helper
    {
        public static string GetStringToLower(string str)
        {
            var a = str.ToLowerInvariant();
            return a;
        }
    }


}