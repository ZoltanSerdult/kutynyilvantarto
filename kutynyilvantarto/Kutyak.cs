using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kutynyilvantarto
{
    class Kutyak
    {
        string nev;
        string fajta;
        double suly;
        int szuletett;

        public string Nev { get => nev; set => nev = value; }
        public string Fajta { get => fajta; set => fajta = value; }
        public double Suly { get => suly; set => suly = value; }
        public int Szuletett { get => szuletett; set => szuletett = value; }

        public Kutyak(string nev, string fajta, double suly, int született)
        {
            Nev = nev;
            Fajta = fajta;
            Suly = suly;
            Szuletett = szuletett;
        }
        public override string ToString()
        {
            return nev;
        }
    }
}
