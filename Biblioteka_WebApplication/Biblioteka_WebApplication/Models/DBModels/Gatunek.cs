using System.Collections.Generic;

namespace Biblioteka_WebApplication.Models.DBModels
{
    public class Gatunek
    {
        public int GatunekId { get; set; }
        public string Nazwa { get; set; }

        public ICollection<Ksiazka> Ksiazki { get; set; }
    }
}
