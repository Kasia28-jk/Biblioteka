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
      //  private readonly IKsiazkaRepository _ksiazkaRepository;
        private readonly IKsiazkaMapper _ksiazkaMapper;
        private readonly BibliotekaContext _bibliotekaContext;
        private readonly KsiazkaRepository _ksiazkaRepository;

        public KsiazkiController(BibliotekaContext bibliotekaContext, KsiazkaRepository ksiazkaRepository)
        {
            _bibliotekaContext = bibliotekaContext;
            _ksiazkaRepository = ksiazkaRepository;
        }
      
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Ksiazka>>> Get()
        {
            return await _ksiazkaRepository.Get();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Ksiazka>> GetKsiazki(int id)
        {
            return await _ksiazkaRepository.GetKsiazki(id);
        }

        [HttpPost]
        public async Task<ActionResult<Ksiazka>> PostKsiazki([FromBody]Ksiazka ksiazka)
        {
            return await _ksiazkaRepository.PostKsiazki(ksiazka);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Ksiazka>> DeleteKsiazki(int id)
        {
            return await _ksiazkaRepository.DeleteKsiazke(id);
        }

    }
}
