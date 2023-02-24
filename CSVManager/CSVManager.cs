using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVM
{
    public static class CSVManager
    {
        public static void AddStudent(string path)
        {
            using (var sw = new StreamWriter(path, true))
            {
                Console.WriteLine("dammi il nome");
                var nome = Console.ReadLine();
                Console.WriteLine("dammi il cognome");
                var cognome = Console.ReadLine();
                Console.WriteLine("inserisci materia");
                var materia = Console.ReadLine();
                Console.WriteLine("inserisci voto");
                var voto = Console.ReadLine();
                sw.WriteLine($"{nome};{cognome};{materia};{voto}");
            }
        }

        public static List<Esame> ReadCsv(string path)
        {
            var result = new List<Esame>();
            using (var sr = new StreamReader(path))
            {
                while (!sr.EndOfStream)
                {
                    var str = sr.ReadLine();
                    var splitted = str.Split(';');
                    result.Add(new Esame()
                    {
                        Nome = splitted[0],
                        Cognome = splitted[1],
                        Materia = splitted[2],
                        Voto = float.Parse(splitted[3])
                    });
                }
            }

            return result;
        }

        public static float GetAvg(List<Esame> list)
        {
            var voti = list.Select(x => x.Voto).ToList();
            return voti.Average();
        }

        public static float GetMax(List<Esame> list)
        {
            var voti = list.Select(x => x.Voto).ToList();
            return voti.Max();
        }
        public static float GetMin(List<Esame> list)
        {
            var voti = list.Select(x => x.Voto).ToList();
            return voti.Min();
        }

        public static float GetAvgBySubject(string input, List<Esame> list)
        {
            var voti = list.Where(x => x.Materia.Equals(input, StringComparison.InvariantCultureIgnoreCase))
                .Select(x => x.Voto);
            return voti.Average();
        }

        public static float GetAvgByStudent(string nome, string cognome, List<Esame> list)
        {
            return list.Where(x => x.Nome.Equals(nome, StringComparison.InvariantCultureIgnoreCase)
                                        && x.Cognome.Equals(cognome, StringComparison.InvariantCultureIgnoreCase))
                .Select(x => x.Voto).Average();
        }

        public static List<Esame> GetEsamiByStudent(string nome, string cognome, List<Esame> list)
        {
            return list.Where(x => x.Nome.Equals(nome, StringComparison.InvariantCultureIgnoreCase)
                                        && x.Cognome.Equals(cognome, StringComparison.InvariantCultureIgnoreCase)).ToList();
        }
    }

    public class Esame
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Materia { get; set; }
        public float Voto { get; set; }
    }
}
