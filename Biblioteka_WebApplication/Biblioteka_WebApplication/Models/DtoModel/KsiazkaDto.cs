using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteka_WebApplication.Models.DtoModel
{
    public class KsiazkaDto
    {
        public string Tytul { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Wydawnictwo { get; set; }
        public long LiczbaStron { get; set; }
        public bool Ebook { get; set; }
    }
}
