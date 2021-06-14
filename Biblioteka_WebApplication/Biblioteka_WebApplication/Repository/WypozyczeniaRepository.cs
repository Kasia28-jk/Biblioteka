using Biblioteka_WebApplication.Data;
using Biblioteka_WebApplication.Models.DBModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteka_WebApplication.Repository
{
    public class WypozyczeniaRepository
    {
        private readonly BibliotekaContext _context;

        public WypozyczeniaRepository(BibliotekaContext context)
        {
            _context = context;
        }

        public async Task<ActionResult<IEnumerable<Wypozyczenie>>> Get()
        {
            return await _context.Wypozyczenia.ToListAsync();
        }

        public async Task<ActionResult<Wypozyczenie>> Get(int id)
        {
            var wypozyczenie = await _context.Wypozyczenia.FindAsync(id);

            if (wypozyczenie == null)
            {
                throw new NotImplementedException(); // -----------------------
                // zmienić na poolecenie nie znaleziono uzytkownika
            }
            return wypozyczenie;
        }
        public async Task<ActionResult<Wypozyczenie>> Post([FromBody] Wypozyczenie wypozyczenie)
        {
            _context.Wypozyczenia.Add(wypozyczenie);
            await _context.SaveChangesAsync();

            return wypozyczenie;
        }

        public async Task<ActionResult<Wypozyczenie>> Put([FromBody] Wypozyczenie wypozyczenie)
        {
            var wyp = _context.Wypozyczenia.Find(wypozyczenie.WypozyczenieId);
            wyp.DataOddania = wypozyczenie.DataOddania;
            return wyp;
        }

        public async Task<ActionResult<Wypozyczenie>> Delete(int id)
        {
            var wypozyczenie = await _context.Wypozyczenia.FindAsync(id);
            if (wypozyczenie == null)
            {
                throw new NotImplementedException();
            }

            _context.Wypozyczenia.Remove(wypozyczenie);
            await _context.SaveChangesAsync();

            return wypozyczenie;
        }
    }
}
