using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorium_z_PO_Zestaw_03
{
    class Ksiazka : Pozycja
    {
        private int liczbaStron;
        private List<Autor> autorzy = new List<Autor>();

        public Ksiazka()
        {
            liczbaStron = 0;
            tytul = "";
            id = 0;
            wydawnictwo = "";
        }

        public Ksiazka(string tytul_, int id_, string wydawnictwo_, int rokWydania_, int liczbaStron_)
        {
            tytul = tytul_;
            id = id_;
            wydawnictwo = wydawnictwo_;
            rokWydania = rokWydania_;
            liczbaStron = liczbaStron_;
        }

        public void DodajAutora(Autor autor)
        {
            autorzy.Add(autor);
        }

        public override void WypiszInfo()
        {
            Console.WriteLine("Książka:");
            Console.WriteLine("Tytuł: " + tytul);
            Console.WriteLine("Id: " + id);
            Console.WriteLine("Wydawnictwo: " + wydawnictwo);
            Console.WriteLine("Rok wydania: " + rokWydania);
            Console.WriteLine("Liczba stron: " + liczbaStron);
            Console.WriteLine("Autorzy: ");
            autorzy.ForEach((a) => a.WypiszInfo());
        }
    }
}
