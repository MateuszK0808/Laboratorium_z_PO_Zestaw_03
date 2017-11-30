using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorium_z_PO_Zestaw_03
{
    class Katalog
    {
        private string dzialTematyczny;
        private List<Pozycja> pozycje = new List<Pozycja>();

        public Katalog()
        {
            dzialTematyczny = "";
        }

        public Katalog(string dzialTematyczny_)
        {
            dzialTematyczny = dzialTematyczny_;
        }


        public void DodajPozycje(Pozycja pozycja)
        {
            pozycje.Add(pozycja);
        }

        public void WypiszInfo()
        {
            Console.WriteLine("Pozycje w katalogu");
            Console.WriteLine("Dział tematyczny " + dzialTematyczny);
            pozycje.ForEach((p) => p.WypiszInfo());
        }
    }
}
