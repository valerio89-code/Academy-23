using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
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
            progettare un software per la gestione di una biblioteca
            gli utenti fornendo nome cognome email password possono effettuare dei prestiti
            libri, DVD
            libro{Codice, titolo, anno, genere, stato (in prestito, disponibile), Autori Lista di autori, numPagine}
            DVD  {Codice, titolo, anno, genere, stato (in prestito, disponibile),Autori Lista di autori, durata}
            l'utente può cercare per titolo o per codice sia i dvd che i libri
            l'utente può prendere in prestito un elemento (libro o DVD)
             */
        }
    }

    public class Persona
    {
        protected string Nome { get; set; }
        public string Cognome { get; set; }
        public Persona(string nome, string cognome)
        {
            Nome = nome;
            Cognome = cognome;
        }

        public override string ToString()
        {
            return $"{Nome} {Cognome}";
        }

        public virtual void Saluta()
        {
            Console.WriteLine($"Ciao sono una persona e mi chiamo {Nome} {Cognome}");
        }
    }

    public class Studente : Persona
    {
        public Studente(string nome, string cognome) : base(nome, cognome)
        {
        }

        public override void Saluta()
        {
            Console.WriteLine($"Ciao sono uno studente e mi chiamo {Nome} {Cognome}");
        }

    }


}