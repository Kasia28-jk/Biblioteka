using Biblioteka_WebApplication.Models.DBModels;
using Biblioteka_WebApplication.Repository;
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

        // GET: api/<WypozyczeniaController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Wypozyczenie>>> Get()
        {
            return await _wRepository.Get();
        }

        // GET api/<WypozyczeniaController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Wypozyczenie>> Get(int id)
        {
            return await _wRepository.Get(id);
        }

        // POST api/<WypozyczeniaController>
        [HttpPost]
        public async Task<ActionResult<Wypozyczenie>> Post([FromBody] Wypozyczenie wypozyczenie)
        {
            return await _wRepository.Post(wypozyczenie);
        }

        // PUT api/<WypozyczeniaController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult<Wypozyczenie>> Put([FromBody] Wypozyczenie wypozyczenie)
        {
            return await _wRepository.Put(wypozyczenie);
        }

        // DELETE api/<WypozyczeniaController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Wypozyczenie>> Delete(int id)
        {
            return await _wRepository.Delete(id);
        }
    }
}
