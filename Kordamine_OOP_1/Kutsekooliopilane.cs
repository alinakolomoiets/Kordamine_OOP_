using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kordamine_OOP_1
{
    class Kutsekooliopilane : Isik
    {
        public string eriala;
        public int kursus;
        public int grupp;
        public enum palk { suur, vaike };
        public palk perePalk;
        public Kutsekooliopilane(string nimi, sugu isikSugu, int synniAasta, int kaal, string eriala, int kursus, int grupp) : base(nimi, kaal, isikSugu, synniAasta)
        {
            this.nimi = nimi;
            this.isikSugu = isikSugu;
            this.synniAasta = synniAasta;
            this.kaal = kaal;
            this.eriala = eriala;
            this.kursus = kursus;
            this.grupp = grupp;

        }
        //public string Toetus()
        //{
        //    if (palk == suur)
        //    {
        //        (palk + 40.5);
        //   } 
        //}

        public override void print_Info()
        {
            Console.WriteLine("See on {0}, sugu on  {1}, ja ta on {2} sünniaasta,  kaal on {3},ta õpib eriala on  {4} , {5} kursus ja tal grupp on  {6} ", nimi, isikSugu , synniAasta, kaal, eriala , kursus, grupp);
        }
    }
}
