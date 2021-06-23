using System.Collections.Generic;

namespace Biblioteka_WebApplication.Models.DBModels
{
    public class Ksiazka
    {
        public int Id { get; set; }
        public string Tytul { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Wydawnictwo { get; set; }
        public long LiczbaStron { get; set; }
        public bool Ebook { get; set; }

       // public ICollection<RelacjaKG> RelacjaKG { get; set; }
        public ICollection<Wypozyczenie> Wypozyczenia { get; set; }
        public ICollection<Gatunek> Gatuneki { get; set; }

        /*
        public void CreateKsiazka(int id, string tytul, string imie, string nazwisko, string wydawnictwo, long liczbaStron, bool ebook)
        {
            Id = id;
            Tytul = tytul;
            Imie = imie;
            Nazwisko = nazwisko;
            Wydawnictwo = wydawnictwo;
            LiczbaStron = liczbaStron;
            Ebook = ebook;
        }*/
    }
}
