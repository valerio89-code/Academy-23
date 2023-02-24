using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Calcolatrice
    {
        /// <summary>
        /// calcola la parte intera della divisione tra due numeri scelti da tastiera
        /// </summary>
        /// <returns>Restituisce un intero</returns>
        /// <exception cref="DivideByZeroException"></exception>
        public int GetDivisione()
        {
            int divisione = 0,
                n1 = 0,
                n2 = 0;
            try
            {
                Console.WriteLine("Inserisci il primo numero");
                var a = Console.ReadLine();
                if (a != null) n1 = int.Parse(a);
                Console.WriteLine("Inserisci il secondo numero");
                n2 = int.Parse(Console.ReadLine());
                divisione = Calculator.Divide(n1, n2);
            }
           finally
            {
                Console.WriteLine("ESECUZIONE IN OGNI CASO");
                Console.WriteLine("Inserisci il secondo numero");
            }

            

            return divisione;
        }
    }

    public static class Calculator
    {
        public static int Divide(int n1, int n2)
        {
            return n1 / n2;
        }
    }

    public class Esame
    {
        public string Matricola { get; private set; }
        public string Materia { get; private set; }
        public float Voto { get; private set; }
        public Esame(string matr, string materia, float voto)
        {
            if (voto < 0 || voto > 10) throw new VotoException();
            Matricola = matr;
            Materia = materia;
            Voto = voto;
        }
    }

    public class VotoException : Exception
    {
        public VotoException() : base("Il voto deve essere compreso tra 1 e 10")
        {

        }
    }

    public class Autore
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Codice { get; set; }
    }

    public class Libro
    {
        public string Titolo { get; set; }
    }
    public class Utente
    {
        private string _password;
        public string Password
        {
            get
            {
                return _password;
            }
            private set
            {
                if (value.Length < 10) throw new Exception();
                _password = value;
            }
        }
        public DateTime DataDiNascita { get; set; }

        public string Password2 { get; set; }

        public string GetAge()
        {
            return (DateTime.Now.Year - DataDiNascita.Year).ToString();
        }
    }


}
