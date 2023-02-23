using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Dato un file in formato csv,il cui tracciato record è:

Nome;Cognome;Materia;Voto

Sviluppare una libreria che implementi le seguenti funzioni (metodi statici):
A)inserisci studente Dammi il nome. dammi il cognome. dammi la materia. dammi il voto.
1)  Caricamento in una lista dei dati del file. 
   Usare una struttura per definire il tracciato record, e limitare la dimensione del vettore al numero di record esistente nel file.
2) Media, Min, Max dei voti totali
3) Media, Min, Max dei voti di una materia (input materia)
4) Media, Min, Max dei voti di uno studente (input nome, cognome)
5) Elenco voti in ordine crescente di uno studente (input nome, cognome)

Sviluppare una console application per richiamare le funzioni della libreria.
            */


            var l = new List<Persona>();
            l.Add(new Persona() { Cognome = "Valdes", Nome = "Valerio", Telefono = "356858457" });
            l.Add(new Persona() { Cognome = "Fiori", Nome = "Valerio", Telefono = "3587474856" });
            l.Add(new Persona() { Cognome = "Rossi", Nome = "Lucrezio", Telefono = "3456989965" });
            l.Add(new Persona() { Cognome = "Verdi", Nome = "Gigi", Telefono = "3216565654" });

            using (var sw = new StreamWriter("C:\\Users\\Valerio\\Source\\Repos\\ConsoleApp7\\FilePersone.csv"))
            {
                foreach (var p in l)
                {
                    sw.WriteLine($"{p.Nome};{p.Cognome};{p.Telefono}");
                }
            }
            //using(var sr = new StreamReader("C:\\Users\\Valerio\\Source\\Repos\\ConsoleApp7\\FileEsempio.txt"))
            //{
            //    while (!sr.EndOfStream)
            //    {
            //        Console.WriteLine(sr.ReadLine());
            //    }
            //}

        }

        public static void AddStudent(string path)
        {
            using (var sw = new StreamWriter(path, true))
            {
                Console.WriteLine("dammi il nome");
                var nome = Console.ReadLine();
                Console.WriteLine("dammi il cognome");
                var cognome = Console.ReadLine();


                sw.WriteLine($"{nome};{cognome};.....");
            }
        }
    }

    public class Persona
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Telefono { get; set; }
    }
}