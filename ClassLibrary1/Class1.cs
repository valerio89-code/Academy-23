using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Persona
    {
        public static int Count { get; set; }
        public string Nome { get; set; }

        ~Persona()
        {
            Count--;
        }
        public Persona()
        {
            Count++;
        }

        //public string GetNomeCompleto(string cognome)
        //{
        //    cognome = "verdi";
        //    return $"{Nome} - {cognome}";
        //}

        public static string GetNomeCompleto(Persona p, string cognome)
        {
            //Persona p = quello che gli ho passato
            p.Nome = "Luca";
            return $"{p.Nome} - {cognome}";
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
    public class Utente : Persona
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
