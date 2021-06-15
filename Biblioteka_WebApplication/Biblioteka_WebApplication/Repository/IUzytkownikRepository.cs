using Biblioteka_WebApplication.Models.DBModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteka_WebApplication.Repository
{
    interface IUzytkownikRepository
    {
        public Task<ActionResult<IEnumerable<Uzytkownik>>> Get();
        public Task<ActionResult<Uzytkownik>> Get(int id);
        public Task<ActionResult<Uzytkownik>> Post([FromBody] Uzytkownik user);
        public Task<ActionResult<Uzytkownik>> Delete(int id);
    }
}
