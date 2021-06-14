using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteka_WebApplication.Models.DBModels
{
    public class Gatunek
    {
        public int GatunekId { get; set; }
        public string Nazwa { get; set; }

        public ICollection<Ksiazka> Ksiazki { get; set; }
    }
}
