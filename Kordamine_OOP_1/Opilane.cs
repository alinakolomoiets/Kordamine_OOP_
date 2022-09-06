using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kordamine_OOP_1
{
    class Opilane:Isik
    {
        public int klass;
        public string koolinimi;
        public string tulemused;
        public int aastaVastuvõtt;

        public Opilane(string nimi, sugu isikSugu, int synniAasta, int kaal, int klass, string koolinimi, string tulemused, int aastaVastuvõtt) : base(nimi,  kaal, isikSugu, synniAasta)
        {
            this.nimi = nimi;
            this.isikSugu = isikSugu;
            this.synniAasta = synniAasta;
            this.kaal = kaal;
            this.klass = klass;
            this.koolinimi = koolinimi;
            this.tulemused = tulemused;
            this.aastaVastuvõtt = aastaVastuvõtt;
        }
        public int vabastadaAasta()
        {
            //int praeguneAasta = DateTime.Now.Year;
            int vabastada = aastaVastuvõtt + 12;
            return vabastada;
        }
        public override void print_Info()
        {
            Console.WriteLine("See on {0}, {1}, ja ta on {2} sünniaasta,  kaal  {3},ta õpib {4} klass, {5} kool ja tal on {6} ", nimi, isikSugu, synniAasta, kaal, klass, koolinimi, tulemused);
        }
    }
}
