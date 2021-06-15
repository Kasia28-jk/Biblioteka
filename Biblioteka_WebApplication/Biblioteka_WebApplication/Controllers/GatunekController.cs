﻿using Biblioteka_WebApplication.Data;
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
    public class GatunekController : ControllerBase
    {
        private readonly BibliotekaContext _bibliotekaContext;
        private readonly GatunekReposiotry _gatunekReposiotry;

        public GatunekController(BibliotekaContext bibliotekaContext, GatunekReposiotry gatunekReposiotry)
        {
            _bibliotekaContext = bibliotekaContext;
            _gatunekReposiotry = gatunekReposiotry;
        }
        // GET: api/<ValuesController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Gatunek>>> Get()
        {
            return await _gatunekReposiotry.Get();
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Gatunek>> GetGatunki(int id)
        {
            return await _gatunekReposiotry.GetGatunki(id);
        }

        // POST api/<ValuesController>
        [HttpPost]
        public async Task<ActionResult<Gatunek>> PostGatunki([FromBody] Gatunek gatunek)
        {
            return await _gatunekReposiotry.PostGatunki(gatunek);
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Gatunek>> DeleteGatunek(int id)
        {
            return await _gatunekReposiotry.DeleteGatunek(id);
        }
    }
}
