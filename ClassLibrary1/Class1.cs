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
        public string nome;
        public readonly int età = 10;
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
        public int Età => DateTime.Now.Year - DataDiNascita.Year;

        public int NameLength
        {
            get
            {
                return nome.Length;
            }
        }

        public string Password2 { get; set; }

        public void Method1()
        {

        }
    }
}
