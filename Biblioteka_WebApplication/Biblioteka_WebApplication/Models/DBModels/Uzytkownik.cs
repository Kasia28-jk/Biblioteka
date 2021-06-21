using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteka_WebApplication.Models.DBModels
{
    public class Uzytkownik
    {
        public int UzytkownikId { get; set; }
        public string Status { get; set; }
        public string Login { get; set; }
        public string Haslo { get; set; }

        public ICollection<Wypozyczenie> Wypozyczenias { get; set; }
    }
}
