using System;

namespace Biblioteka_WebApplication.Models.DtoModel
{
    public class WypozyczeniaDto
    {
        public int WypozyczenieId { get; set; }
        public DateTime DataWypozyczenia { get; set; }
        public DateTime DataOddania { get; set; }
        public int KsiazkaID { get; set; }
        public int UzytkownikID { get; set; }

    }
}
