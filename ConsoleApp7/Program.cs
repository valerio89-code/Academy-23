using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Linq;
using System.Net.Http;
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

            /*
             agenzia: {immobili{codice, tipologia, prezzo, città, superficie}}
             mostraImmobili(string ordinatiPer [codice, prezzo,città,superficie])
             aggiungiImmobile(codice, tipologia, prezzo, città, superficie) //CODICE DEVE ESSERE UNIVOCO
             rimuoviImmobile()
            getImmobilePiùCaro()
            getImmobilePiùGrande()
            getValoreTotaleImmobili()
             */
            var l = new List<Autore>
            {
                new Autore { Cognome = "rossi", Nome = "Mario", Codice = "rm1" },
                new Autore { Cognome = "verdi", Nome = "Mario", Codice = "vm1" },
                new Autore { Cognome = "rossi", Nome = "Luca", Codice = "rl1" },
                new Autore { Cognome = "Bianchi", Nome = "Gino", Codice = "bg1" },
                new Autore { Cognome = "blu", Nome = "Andrea", Codice = "ba1" }
            };
            
            
            //var l2 = new List<Autore>();
            //l2.Add(l[0]);
            l.Remove(new Autore());
            string searchString = Console.ReadLine();
            //action, predicate, func
            Func<int, int, string> somma = (n1, n2) => { return (n1 + n2).ToString(); };
            List<Autore> marios = l.FindAll((f) => f.Nome == searchString);

            if (l.Exists(a => a.Nome == "mario"))
            {
                Console.WriteLine("exist: esiste almeno un mario");
            }
            //LINQ
            if (l.Any(a => a.Nome == "mario"))
            {
                Console.WriteLine("any: esiste almeno un mario");
            }

            Console.WriteLine(l.Count);
            Console.ReadLine();
        }
    }

    public class Catalogo<T>
    {
        private List<T> _elenco = new List<T>();

        public void Add(T item)
        {
            _elenco.Add(item);
        }

        public int GetCount()
        {
            return _elenco.Count;
        }

        public T GetFirst()
        {
            return _elenco.FirstOrDefault();
        }
    }


}