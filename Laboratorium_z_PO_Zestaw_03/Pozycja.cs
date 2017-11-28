using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorium_z_PO_Zestaw_03
{
    public abstract class Pozycja
    {
        protected string tytul;
        protected int id;
        protected string wydawnictwo;
        protected int rokWydania;

        public Pozycja()
        {
            tytul = "";
            id = 0;
            wydawnictwo = "";
            rokWydania = 0;
        }
        public Pozycja(string tytul_, int id_, string wydawnictwo_, int rokWydania_)
        {
            tytul = tytul_;
            id = id_;
            wydawnictwo = wydawnictwo_;
            rokWydania = rokWydania_;
        }
        public abstract void WypiszInfo();
    }
}
