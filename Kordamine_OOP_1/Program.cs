using Kordamine_OOP_1;
// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//Koduloom kass = new Koduloom("Murka", "punane", 'E', 5.5, 7, true);
//kass.print_Info();
//Koduloom kassKloon = new Koduloom(kass);
//kassKloon.muuda_Nimi("MurkaKloon");
//kassKloon.print_Info();
//kassKloon.muuda_Kaal(6.7);
//kassKloon.print_Info();
//kassKloon.muuda_Vanus(1);
//kassKloon.print_Info();
//Gekko gekko = new Gekko("Leopardi" ,"Nemo", "punane", Koduloom.sugu.isane, 0.9, 2, true);
//gekko.print_Info();
//Isik inimene = new Isik ("Lina" ,2004 , Isik.sugu.naine,47.5);
//inimene.print_Info();
//int a = inimene.arvutaVanus();
//Console.WriteLine(a);
List<Isik> inimised = new List<Isik>();
//1
Töötaja töötaja = new Töötaja("Lija", Isik.sugu.naine, 2003, 19, "klienditeenindaja", 1830, 50, 2400, "Ümera keskus");
töötaja.print_Info();
//2
//Töötaja töötaja1 = new Töötaja(töötaja);
//töötaja1.muuda_Sugu(Isik.sugu.naine);
//töötaja1.muuda_Nimi("Kara");
//töötaja1.print_Info();

Opilane opilane = new Opilane("Lia", Isik.sugu.naine, 1999, 59,10, "Ehte", "head" , 2011);
opilane.print_Info();
int a = opilane.arvutaVanus();
Console.WriteLine(a);
int b = opilane.vabastadaAasta();
Console.WriteLine(b);
Kutsekooliopilane kutsekooliopilane = new Kutsekooliopilane("Maks", Isik.sugu.mees ,2005 , 78,"Noorem tarkvaraarendaja",2,"TARpv21",Kutsekooliopilane.palk.suur );
kutsekooliopilane.print_Info();


inimised.Add(töötaja);
//inimised.Add(töötaja1);
inimised.Add(opilane);
inimised.Add(kutsekooliopilane);
StreamWriter to_file = new StreamWriter(@"..\..\..\Inimised.txt", false);
foreach (Isik p in inimised)
{
    p.print_Info();
    to_file.WriteLine(p.nimi + ", " + p.arvutaVanus() + ", " + p.isikSugu + ";");
}
to_file.Close();
StreamReader from_file = new StreamReader(@"..\..\..\Inimised.txt");
string text =from_file.ReadToEnd();
Console.WriteLine(text);
from_file.Close();

List<Isik> loetudFailist = new List<Isik>();
StreamReader sr = new StreamReader(@"..\..\..\Inimised.txt");
List<string> lines = new List<string>();
int n = sr.ReadToEnd().Split(new char[] { '\n' }).Length;
Console.WriteLine("------"+ n+"-----");




