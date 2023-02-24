

using CSVM;
using System;
using System.Xml.Linq;

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
            var path = "C:\\Users\\Valerio\\Source\\Repos\\ConsoleApp7\\FileStudenti.csv";
            while (true)
            {
                Console.WriteLine("Inserire OK per inserire gli utenti nel CSV. inserire exit per terminare l'inserimento");
                var input = Console.ReadLine();
                if (input.Equals("exit", StringComparison.InvariantCultureIgnoreCase))
                {
                    Console.WriteLine("inserimento studenti terminato");
                    break;
                }
                CSVManager.AddStudent(path);
            }

            var esami = CSVManager.ReadCsv(path);
            Console.WriteLine(CSVManager.GetAvg(esami));
            Console.WriteLine(CSVManager.GetAvgByStudent("valerio", "valdes", esami));
            //var auto = new Auto() { Modello = "fiat" };
            //var persona = new Persona(auto) { Nome = "valerio" };
            //Console.WriteLine(persona.Auto.Modello);
        }


    }
    public class Auto
    {
        public string Modello { get; set; }
    }
    
    public class Persona
    {
        public readonly Auto Auto;
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Telefono { get; set; }
        public Persona(Auto a)
        {
            Auto = a;
        }
    }
}