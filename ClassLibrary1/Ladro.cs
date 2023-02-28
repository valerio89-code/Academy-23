using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Ladro
    {
        public string Nome { get; set; }
        public string Specialità { get; set; }

        public void CheckPorta(string nomeCasa)
        {
            Console.WriteLine($"io {Nome}, specializzato in {Specialità}, " +
                $"vado a vedere se c'è qualcuno alla porta della casa {nomeCasa} in cui sto rubando");
        }
    }
}
