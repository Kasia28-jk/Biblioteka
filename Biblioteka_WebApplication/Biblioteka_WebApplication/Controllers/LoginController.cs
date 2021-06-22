using Biblioteka_WebApplication.Models.DBModels;
using Biblioteka_WebApplication.Repository;
using Biblioteka_WebApplication.Repository.DtoModel;
using Microsoft.AspNetCore.Mvc;

namespace Biblioteka_WebApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : Controller
    {
        private readonly IUzytkownikRepository _uRepository;

        public LoginController(IUzytkownikRepository uzytkownikRepository)
        {
            _uRepository = uzytkownikRepository;
        }

        [HttpPost]
        public LoginResDto Login([FromBody] Uzytkownik uzytkownik)
        {
            return _uRepository.Login(uzytkownik);
        }

    }
}
