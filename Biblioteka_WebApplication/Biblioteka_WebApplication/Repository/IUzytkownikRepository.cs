using Biblioteka_WebApplication.Models.DBModels;
using Biblioteka_WebApplication.Repository.DtoModel;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Biblioteka_WebApplication.Repository
{
    public interface IUzytkownikRepository
    {
        public Task<ActionResult<IEnumerable<Uzytkownik>>> Get();
        public Task<ActionResult<Uzytkownik>> Get(int id);
        public Task<ActionResult<Uzytkownik>> Post([FromBody] Uzytkownik user);
        public Task<ActionResult<Uzytkownik>> Delete(int id);
        public LoginResDto Login([FromBody] Uzytkownik uzytkownik);
    }
}
