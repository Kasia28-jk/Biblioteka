using Biblioteka_WebApplication.Models.DBModels;
using Biblioteka_WebApplication.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
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
        [Authorize]
        public async Task<ActionResult<IEnumerable<Ksiazka>>> Get()
        {
            return await _ksiazkaRepository.Get();
        }

        [HttpGet("{id}")]
        [Authorize]
        public async Task<ActionResult<Ksiazka>> GetKsiazka(int id)
        {
            return await _ksiazkaRepository.GetKsiazka(id);
        }

        [HttpPost]
        [Authorize]
        public async Task<ActionResult<Ksiazka>> PostKsiazka([FromBody]Ksiazka ksiazka)
        {
            return await _ksiazkaRepository.PostKsiazki(ksiazka);
        }

        [HttpDelete("{id}")]
        [Authorize]
        public async Task<ActionResult<Ksiazka>> DeleteKsiazka(int id)
        {
            return await _ksiazkaRepository.DeleteKsiazke(id);
        }

    }
}
