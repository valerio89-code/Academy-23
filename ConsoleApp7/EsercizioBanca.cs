using System;

namespace ConsoleApp7
{
    public class Banca
    {
        public const int numero = 10;
        public readonly string indirizzo = "via dei mille";
        public int Id { get; set; }
        public string Nome { get; set; } = "ING";
        public string Codice { get; set; }
        public Cliente[] Clienti { get; set; } = new Cliente[10];
        public string NomeCompleto => $"{Nome} - {Codice}";

        public Banca(string nome)
        {
            Nome = nome;
            indirizzo = "via del campo";
        }
        public Banca(int id, string codice)
        {
            Codice = codice;
            Id = id;
            indirizzo = "via del fiore";
        }

        ~Banca()
        {
            Console.WriteLine("ciao è stato bello");
        }

        private Cliente GetClientePrestitoPiùAlto()
        {
            Cliente result = null;
            double maxStipendio = 0;
            for (int i = 0; i < 10; i++)
            {
                if (Clienti[i].Stipendio > maxStipendio)
                {
                    result = Clienti[i];
                }
            }
            return result;
        }

    }

    public class Cliente
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public double Stipendio { get; set; }

        public double GetPrestitoDisponibile()
        {
            return Stipendio / 2;
        }

    }
}
