using Biblioteka_WebApplication.Models.DBModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteka_WebApplication.Repository
{
    public interface IWypozyczeniaRepository
    {
        public Task<ActionResult<IEnumerable<Wypozyczenie>>> Get();
        public Task<ActionResult<Wypozyczenie>> Get(int id);
        public Task<ActionResult<Wypozyczenie>> Post([FromBody] Wypozyczenie wypozyczenie);
        public Task<ActionResult<Wypozyczenie>> Put([FromBody] Wypozyczenie wypozyczenie);
        public Task<ActionResult<Wypozyczenie>> Delete(int id);
    }
}
