using Biblioteka_WebApplication.Models.DBModels;
using Biblioteka_WebApplication.Models.DtoModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteka_WebApplication.Mappers
{
    interface IKsiazkaMapper
    {
        public IList<KsiazkaDto> MapRespone(IList<Ksiazka> newKsiazkaList);
    }
}
