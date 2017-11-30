using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorium_z_PO_Zestaw_03
{
    class Autor
    {
        private string imie;
        private string nazwisko;

        public Autor()
        {
            imie = "";
            nazwisko = "";
        }

        public Autor(string imie_, string nazwisko_)
        {
            this.imie = imie_;
            this.nazwisko = nazwisko_;
        }

        public void WypiszInfo()
        {
            Console.WriteLine("  -{0} {1}", imie, nazwisko);
        }
    }
}
