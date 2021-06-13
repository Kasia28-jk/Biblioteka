using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteka_WebApplication.Models
{
    public class Wypozyczenie
    {
        public int WypozyczenieId { get; set; }
        public DateTime DataWypozyczenia { get; set; }
        public DateTime DataOddania { get; set; }
        public int KsiazkaID { get; set; }
        public int UzytkownikID { get; set; }

        public Ksiazka Ksiazka { get; set; }
        public Uzytkownik Uzytkownik { get; set; }
    }
}
