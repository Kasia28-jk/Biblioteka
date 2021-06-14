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
    }
}
