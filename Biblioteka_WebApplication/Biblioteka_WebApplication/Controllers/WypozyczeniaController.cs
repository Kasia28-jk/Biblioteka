using Biblioteka_WebApplication.Models.DBModels;
using Biblioteka_WebApplication.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Biblioteka_WebApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WypozyczeniaController : ControllerBase
    {
        private readonly IWypozyczeniaRepository _wRepository;

        public WypozyczeniaController(IWypozyczeniaRepository wypozyczeniaRepository)
        {
            _wRepository = wypozyczeniaRepository;
        }

        // GET: api/<WypozyczeniaController>
        [HttpGet]
        [Authorize]
        public async Task<ActionResult<IEnumerable<Wypozyczenie>>> Get()
        {
            return await _wRepository.Get();
        }

        // GET api/<WypozyczeniaController>/5
        [HttpGet("{id}")]
        [Authorize]
        public async Task<ActionResult<Wypozyczenie>> Get(int id)
        {
            return await _wRepository.Get(id);
        }

        // POST api/<WypozyczeniaController>
        [HttpPost]
        [Authorize]
        public async Task<ActionResult<Wypozyczenie>> Post([FromBody] Wypozyczenie wypozyczenie)
        {
            return await _wRepository.Post(wypozyczenie);
        }

        // PUT api/<WypozyczeniaController>/5
        [HttpPut("{id}")]
        [Authorize]
        public async Task<ActionResult<Wypozyczenie>> Put([FromBody] Wypozyczenie wypozyczenie)
        {
            return await _wRepository.Put(wypozyczenie);
        }

        // DELETE api/<WypozyczeniaController>/5
        [HttpDelete("{id}")]
        [Authorize]
        public async Task<ActionResult<Wypozyczenie>> Delete(int id)
        {
            return await _wRepository.Delete(id);
        }
    }
}
