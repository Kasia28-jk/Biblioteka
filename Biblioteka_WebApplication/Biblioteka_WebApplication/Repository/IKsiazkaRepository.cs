using Biblioteka_WebApplication.Models.DBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteka_WebApplication.Repository
{
    public interface IKsiazkaRepository
    {
        public Task<IList<Ksiazka>> GetKsiazkiList();
    }
}
