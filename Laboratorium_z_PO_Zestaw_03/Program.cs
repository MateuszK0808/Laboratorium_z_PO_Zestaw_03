using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorium_z_PO_Zestaw_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadanie 1");

            Katalog katalog = new Katalog("Książki");
            Czasopismo czasopismo = new Czasopismo("gazeta", 1, "wszip", 1999, 2);
            Ksiazka ksiazka = new Ksiazka("Jakas książka", 2, "ORelly", 1889, 432);

            czasopismo.WypiszInfo();
            ksiazka.WypiszInfo();

            Autor autor = new Autor("Jan", "Kowalski");
            ksiazka.DodajAutora(autor);
            ksiazka.WypiszInfo();

            katalog.DodajPozycje(ksiazka);
            katalog.DodajPozycje(czasopismo);

            katalog.WypiszInfo();



            Console.ReadKey();
        }
    }
}
