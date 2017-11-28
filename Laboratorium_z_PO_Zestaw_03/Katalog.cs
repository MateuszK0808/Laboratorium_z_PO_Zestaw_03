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
            DzialTematyczny = "";
        }

        public Katalog(string dzialTematyczny_)
        {
            DzialTematyczny = dzialTematyczny_;
        }

        public string DzialTematyczny { get => dzialTematyczny; set => dzialTematyczny = value; }

        public void DodajPozycje(Pozycja pozycja)
        {
            pozycje.Add(pozycja);
        }
    }
}
