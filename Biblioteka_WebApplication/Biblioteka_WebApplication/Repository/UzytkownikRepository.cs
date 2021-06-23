using Biblioteka_WebApplication.Data;
using Biblioteka_WebApplication.Models.DBModels;
using Biblioteka_WebApplication.Models.DtoModel;
using Biblioteka_WebApplication.Repository.DtoModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka_WebApplication.Repository
{
    public class UzytkownikRepository : IUzytkownikRepository
    {
        private readonly BibliotekaContext _context;

        public UzytkownikRepository(BibliotekaContext context)
        {
            _context = context;
        }

        public async Task<ActionResult<IEnumerable<Uzytkownik>>> Get()
        {
            return await _context.Uzytkownik.ToListAsync();
        }

        public async Task<ActionResult<Uzytkownik>> Get(int id)
        {
            var user = await _context.Uzytkownik.FindAsync(id);

            if (user == null)
            {
                throw new NotImplementedException(); // -----------------------
                // zmienić na poolecenie nie znaleziono uzytkownika
            }
            return user;
        }

        public async Task<ActionResult<Uzytkownik>> Post([FromBody]Uzytkownik user)
        {
            _context.Uzytkownik.Add(user);
            await _context.SaveChangesAsync();

            return user;
        }

        public async Task<ActionResult<Uzytkownik>> Delete(int id)
        {
            var user = await _context.Uzytkownik.FindAsync(id);
            if (user == null)
            {
                throw new NotImplementedException();
            }

            _context.Uzytkownik.Remove(user);
            await _context.SaveChangesAsync();

            return user;
        }
    }
}
