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
            var l = new List<Forma>();
            l.Add(new Rettangolo() { Altezza = 10, Base = 20 });
            l.Add(new Cerchio() { Raggio = 3 });
            l.Add(new Quadrato() { Lato = 5 });
/*
Si vuole realizzare un sistema per la gestione di Corsi. 

Ciascun corso ha un nome e un numero intero che indica l’edizione. 
Ciascun corso si articola in un certo numero di lezioni. 
Ogni lezione ha una descrizione, una data, un orario di inizio, una durata, un docente e un’aula assegnata.

I Docenti hanno un nome, un cognome e un titolo di studio.

Ogni Aula ha una capienza, un nome e un elenco di risorse (es. Video Proiettore, PC, Notebook, Tablet, LIM, etc.).

Ogni corso ha un certo numero di studenti partecipanti, iscritti a quella specifica edizione. 
Ogni studente ha un nome, un cognome e una matricola. 
Per ogni lezione occorre tenere traccia dei presenti.

Il sistema deve consentire:
Aggiungere corso
Aggiungere lezioni ad un corso
Aggiungere studenti ad un corso
Segnare gli assenti ad una lezione

Il sistema deve consentire le seguenti stampe a video:
Elenco Corsi
Elenco delle lezioni di un corso
Elenco degli iscritti a un corso
Scheda riassuntiva di una lezione
Elenco dei presenti ad una lezione
*/
        }
    }

    public abstract class Forma
    {
        public virtual void Disegna()
        {
            Console.WriteLine("Sto disegnando una forma generica");
        }
        public virtual void StampaDimensioni()
        {
            Console.WriteLine($"{Environment.NewLine}Le dimensioni dell'oggetto sono:");
        }
        public abstract double GetPerimetro();
    }
    public class Rettangolo : Forma
    {
        public int Altezza { get; set; }
        public int Base { get; set; }
        public override void Disegna()
        {
            Console.WriteLine("Sto disegnando un rettangolo");
        }

        public override double GetPerimetro()
        {
            return Altezza * 2 + Base * 2;
        }

        public virtual void StampaDimensioni()
        {
            base.StampaDimensioni();
            Console.WriteLine($"Altezza: {Altezza} {Environment.NewLine}Base: {Base}");
        }
    }
    public class Cerchio : Forma
    {
        public int Raggio { get; set; }
        public override void Disegna()
        {
            Console.WriteLine("Sto disegnando un cerchio");
        }

        public override double GetPerimetro()
        {
            return Math.Pow(Raggio, 2) * Math.PI;
        }

        public override void StampaDimensioni()
        {
            base.StampaDimensioni();
            Console.WriteLine($"Raggio: {Raggio}");
        }
    }
    public class Quadrato : Rettangolo
    {
        public int Lato { get; set; }
        public override void Disegna()
        {
            Console.WriteLine("Sto disegnando un quadrato");
        }
        public override void StampaDimensioni()
        {
            base.StampaDimensioni();
            Console.WriteLine($"Lato: {Lato}");
        }

        public override double GetPerimetro()
        {
            return Lato * 4;
        }
    }


}