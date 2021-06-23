using Biblioteka_WebApplication.Models.DBModels;
using Biblioteka_WebApplication.Models.DtoModel;
using Biblioteka_WebApplication.Repository;
using Biblioteka_WebApplication.Repository.DtoModel;
using Microsoft.AspNetCore.Mvc;

namespace Biblioteka_WebApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : Controller
    {
        private readonly ILoginRepository _uRepository;

        public LoginController(ILoginRepository uzytkownikRepository)
        {
            _uRepository = uzytkownikRepository;
        }

        [HttpPost]
        public LoginResDto LoginaM([FromBody] UzytkownikDto uzytkownik)
        {
            return _uRepository.LoginM(uzytkownik);
        }

    }
}
