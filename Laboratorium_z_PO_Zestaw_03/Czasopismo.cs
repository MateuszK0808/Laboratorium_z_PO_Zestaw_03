using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorium_z_PO_Zestaw_03
{
    class Czasopismo : Pozycja
    {
        private int numer;

        public Czasopismo()
        {
            tytul = "";
            id = 0;
            wydawnictwo = "";
            rokWydania = 0;
            numer = 0;
        }
        public Czasopismo(string tytul_, int id_, string wydawnictwo_, int rokWydania_, int numer_)
        {
            tytul = tytul_;
            id = id_;
            wydawnictwo = wydawnictwo_;
            rokWydania = rokWydania_;
            numer = numer_;
        }
        public override void WypiszInfo()
        {
            Console.WriteLine("Czasopismo:");
            Console.WriteLine("Tytuł:" + tytul);
            Console.WriteLine("Id: " + id);
            Console.WriteLine("Wydawnictwo: " + wydawnictwo);
            Console.WriteLine("Rok wydania: " + rokWydania);
            Console.WriteLine("Number: " + numer);
        }
    }
}
