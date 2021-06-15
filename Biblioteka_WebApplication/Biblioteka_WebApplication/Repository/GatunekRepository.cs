using Biblioteka_WebApplication.Controllers;
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
    public class GatunekReposiotry : Controller
    {
        private readonly BibliotekaContext _bibliotekaContext;
        public GatunekReposiotry(BibliotekaContext bibliotekaContext)
        {
            _bibliotekaContext = bibliotekaContext;
        }

        public async Task<ActionResult<IEnumerable<Gatunek>>> Get()
        {
            return await _bibliotekaContext.Gatunki.ToListAsync();
        }

        public async Task<ActionResult<Gatunek>> GetGatunki(int id)
        {
            var gatunek = await _bibliotekaContext.Gatunki.FindAsync(id);

            if (gatunek == null)
            {
                throw new NotImplementedException();
                //return NotFound();
            }
            return gatunek; 
        }

        public async Task<ActionResult<Gatunek>> PostGatunki([FromBody] Gatunek gatunek)
        {
            _bibliotekaContext.Gatunki.Add(gatunek);
            await _bibliotekaContext.SaveChangesAsync();

            return gatunek;
        }

        public async Task<ActionResult<Gatunek>> DeleteGatunek(int id)
        {
            var gatunek = await _bibliotekaContext.Gatunki.FindAsync(id);
            if (gatunek == null)
            {
                throw new NotImplementedException();
            }

            _bibliotekaContext.Gatunki.Remove(gatunek);
            await _bibliotekaContext.SaveChangesAsync();

            return gatunek;
        }
    }
}
