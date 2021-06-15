using Biblioteka_WebApplication.Models.DBModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteka_WebApplication.Repository
{
    public interface IGatunekRepository
    {
        public Task<ActionResult<IEnumerable<Gatunek>>> Get();
        public Task<ActionResult<Gatunek>> GetGatunki(int id);
        public Task<ActionResult<Gatunek>> PostGatunki([FromBody] Gatunek gatunek);
        public Task<ActionResult<Gatunek>> DeleteGatunek(int id);
    }
}
