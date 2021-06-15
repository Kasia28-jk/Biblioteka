using Biblioteka_WebApplication.Models.DBModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteka_WebApplication.Repository
{
    public interface IKsiazkaRepository
    {
        public Task<ActionResult<IEnumerable<Ksiazka>>> Get();
        public Task<ActionResult<Ksiazka>> GetKsiazka(int id);
        public Task<ActionResult<Ksiazka>> PostKsiazki([FromBody] Ksiazka ksiazka);
        public Task<ActionResult<Ksiazka>> DeleteKsiazke(int id);

    }
}
