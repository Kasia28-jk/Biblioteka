using Biblioteka_WebApplication.Data;
using Biblioteka_WebApplication.Models.DBModels;
using Biblioteka_WebApplication.Models.DtoModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Biblioteka_WebApplication.Repository
{
    public class KsiazkaRepository : IKsiazkaRepository
    {
        private readonly BibliotekaContext _bibliotekaContext;
        public KsiazkaRepository(BibliotekaContext bibliotekaContext)
        {
            _bibliotekaContext = bibliotekaContext;
        }

        public async Task<ActionResult<IEnumerable<Ksiazka>>> Get()
        {
            return await _bibliotekaContext.Ksiazki.ToListAsync();
        }

        public async Task<ActionResult<Ksiazka>> GetKsiazka(int id)
        {
            var ksiazka = await _bibliotekaContext.Ksiazki.FindAsync(id);

            if (ksiazka == null)
            {
                throw new NotImplementedException();
                //return NotFound();
            }
            return ksiazka;
        }

        public async Task<ActionResult<Ksiazka>> PostKsiazki([FromBody] Ksiazka ksiazka)
        {
            _bibliotekaContext.Ksiazki.Add(ksiazka);
            await _bibliotekaContext.SaveChangesAsync();

            return ksiazka;
        }

        public async Task<ActionResult<Ksiazka>> DeleteKsiazke(int id)
        {
            var ksiazki = await _bibliotekaContext.Ksiazki.FindAsync(id);
            if (ksiazki == null)
            {
                throw new NotImplementedException();
            }

            _bibliotekaContext.Ksiazki.Remove(ksiazki);
            await _bibliotekaContext.SaveChangesAsync();

            return ksiazki;
        }
    }
}
