using Biblioteka_WebApplication.Data;
using Biblioteka_WebApplication.Models.DBModels;
using Biblioteka_WebApplication.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Biblioteka_WebApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UzytkownikController : ControllerBase
    {
        private readonly IUzytkownikRepository _uRepository;

        public UzytkownikController(IUzytkownikRepository uzytkownikRepository)
        {
            _uRepository = uzytkownikRepository;
        }

        // GET: api/<UzytkownikController>
        [HttpGet]
        [Authorize(Roles ="Admin")]

        public async Task<ActionResult<IEnumerable<Uzytkownik>>> Get()
        {
            return await _uRepository.Get();
        }

        // GET api/<UzytkownikController>/5
        [HttpGet("{id}")]
        [Authorize]
        public async Task<ActionResult<Uzytkownik>> Get(int id)
        {
            return await _uRepository.Get(id);
        }

        // POST api/<UzytkownikController>
        [HttpPost]
        [Authorize]
        public async Task<ActionResult<Uzytkownik>> Post([FromBody] Uzytkownik user)
        {
            return await _uRepository.Post(user);
        }

        // DELETE api/<UzytkownikController>/5
        [HttpDelete("{id}")]
        [Authorize]
        public async Task<ActionResult<Uzytkownik>> Delete(int id)
        {
            return await _uRepository.Delete(id);
        }
    }
}
