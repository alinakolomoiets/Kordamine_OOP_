using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kordamine_OOP_1
{
    abstract class Isik
    {
       /* public string nimi;
        public int synniAasta;
        public enum sugu {mees, naine};
        public sugu isikSugu;
        public double kaal;
        public int vanus;
        public Isik (string nimi, int synniAasta, sugu isikSugu, double kaal)
        {
            this.nimi = nimi;
            this.synniAasta = synniAasta;
            this.isikSugu = isikSugu;
            this.kaal = kaal;
        }
        public Isik (Isik inimene)
        {
            this.nimi = inimene.nimi;
            this.synniAasta = inimene.synniAasta;
            this.isikSugu = inimene.isikSugu;
            this.kaal = inimene.kaal;
        }
        public abstract void print_Info();
        //{
        //    Console.WriteLine("{0} {1} {2} {3}  " , nimi , synniAasta , isikSugu,kaal , vanus);
        //}
        public int arvutaVanus()
        {
            int praeguneAasta = DateTime.Now.Year;
            int vanus = praeguneAasta - synniAasta;
            return vanus;
        }
        public void muuda_Nimi(string uusNimi)
        {
            nimi = uusNimi;
        }
        public void muuda_Kaal(double uusKaal)
        {
            kaal = uusKaal;
        }
        public void muuda_Vanus(int uusVanus)
        {
            vanus = uusVanus;
        }
        public void muuda_Sugu(sugu uusSugu)
        {
            isikSugu = (sugu)uusSugu;
        }



    }   
}
