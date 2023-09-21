using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_09_21_Filmprojekt
{
    internal class Film
    {
        private int helyezes;
        private string cim;
        private int ev;
        private int hossz;
        private List<string> mufaj;

        public Film(string sor)
        {
            string[] adatok = sor.Split(';');
            this.helyezes = int.Parse(adatok[0].Substring(0, adatok[0].Length-1));
            this.cim = adatok[1];
            this.ev = int.Parse(adatok[2]);
            this.hossz = int.Parse(adatok[3].Split(' ')[0]);
            this.mufaj = new List<string>();
            string[] mufajok = adatok[4].Split(',');
            foreach (var item in mufajok)
            {
                this.mufaj.Add(item.Trim());
            }
        }

        public Film(int helyezes, string cim, int ev, int hossz, List<string> mufaj)
        {
            this.helyezes = helyezes;
            this.cim = cim;
            this.ev = ev;
            this.hossz = hossz;
            this.mufaj = mufaj;
        }

        public int Helyezes { get => helyezes; set => helyezes = value; }
        public string Cim { get => cim; set => cim = value; }
        public int Ev { get => ev; set => ev = value; }
        public int Hossz { get => hossz; set => hossz = value; }
        public List<string> Mufaj { get => mufaj; set => mufaj = value; }
    }
}
