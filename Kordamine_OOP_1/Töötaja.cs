using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kordamine_OOP_1
{
    class Töötaja : Isik
    {
        public string asutus;
        public string amet;
        public double tootasu;
        public double maksuvaba;
        public double tulumaks;
        public Töötaja(string nimi, sugu isikSugu, int synniAasta, int kaal, string amet, double tootasu, double maksuvaba, double tulumaks, string asutus) : base(nimi, kaal, isikSugu, synniAasta)
        {
            this.asutus = asutus;
            this.amet = amet;
            this.tootasu=tootasu;
            this.maksuvaba=maksuvaba;
            this.tulumaks=tulumaks;
        }
        public double arvutaSissetulek (double maksuvaba , double tulumaks , double tootasu)
        {
            double netopalk = ((tootasu - maksuvaba) + (1 - (tulumaks / 100)));
            return netopalk;
        }
        public override void print_Info()
        {
            Console.WriteLine($"See on {nimi}, {isikSugu}, ja ta on {synniAasta} sünniaasta, tema kaal on {kaal},ta töötab {amet}ks {asutus}es, tema palk on {arvutaSissetulek(maksuvaba,tulumaks,tootasu)}");
        }
    }
}
