using Biblioteka_WebApplication.Data;
using Biblioteka_WebApplication.Mappers;
using Biblioteka_WebApplication.Models.DBModels;
using Biblioteka_WebApplication.Repository;
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
    public class KsiazkiController : ControllerBase
    {
        private readonly IKsiazkaRepository _ksiazkaRepository;

        public KsiazkiController(IKsiazkaRepository ksiazkaRepository)
        {
            _ksiazkaRepository = ksiazkaRepository;
        }
      
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Ksiazka>>> Get()
        {
            return await _ksiazkaRepository.Get();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Ksiazka>> GetKsiazka(int id)
        {
            return await _ksiazkaRepository.GetKsiazka(id);
        }

        [HttpPost]
        public async Task<ActionResult<Ksiazka>> PostKsiazka([FromBody]Ksiazka ksiazka)
        {
            return await _ksiazkaRepository.PostKsiazki(ksiazka);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Ksiazka>> DeleteKsiazka(int id)
        {
            return await _ksiazkaRepository.DeleteKsiazke(id);
        }

    }
}
