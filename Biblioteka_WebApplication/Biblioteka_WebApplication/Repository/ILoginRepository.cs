using Biblioteka_WebApplication.Models.DtoModel;
using Biblioteka_WebApplication.Repository.DtoModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteka_WebApplication.Repository
{
    public interface ILoginRepository
    {
        public LoginResDto Login(UzytkownikDto uzytkownik);
    }
}
