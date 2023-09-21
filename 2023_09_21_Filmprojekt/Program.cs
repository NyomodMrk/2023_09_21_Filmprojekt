using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_09_21_Filmprojekt
{
    internal class Program
    {
        static List<Film> filmek = new List<Film>();
        static void Main(string[] args)
        {
            Fajlbeolvasasa("filmadatbazis.csv");
            foreach (var item in filmek)
            {
                Console.WriteLine(item.Cim);
            }
        }

        private static void Fajlbeolvasasa(string fajlNev)
        {
            using(StreamReader fileReader = new StreamReader(fajlNev))
            {
                fileReader.ReadLine();
                while (!fileReader.EndOfStream)
                {
                    string sor = fileReader.ReadLine();
                    Film film = new Film(sor);
                    filmek.Add(film);
                }
            }
        }
    }
}
