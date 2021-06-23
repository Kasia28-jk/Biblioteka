using Biblioteka_WebApplication.Data;
using Biblioteka_WebApplication.Models.DtoModel;
using Biblioteka_WebApplication.Repository.DtoModel;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka_WebApplication.Repository
{
    public class LoginRepository : ILoginRepository
    {
        private readonly BibliotekaContext _bibliotekaContext;
        public LoginRepository(BibliotekaContext context)
        {
            _bibliotekaContext = context;
        }
        public LoginResDto LoginM(UzytkownikDto uzytkownik)
        {
            var res = new LoginResDto();
            /*var uzyt = _bibliotekaContext.Uzytkownik.FirstOrDefault(u => u.Login == uzytkownik.Login);

            if (uzyt == null)
            {
                return null;
            }

            if (uzyt.Haslo != uzytkownik.Haslo)
            {
                return null;
            }*/

            if(uzytkownik.Login==null)
            {
                res.Rola = "Bibliotekarz";
            }
            if (uzytkownik.Login == "Admin")
            {
                res.Rola = "Admin";
            }
            var klucz = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("bardzotrudnehaslotokena"));
            var zaszfrowanyKlucz = new SigningCredentials(klucz, SecurityAlgorithms.HmacSha256);
            var token = new JwtSecurityToken("http://localhost:44383/", null, new List<Claim> { new Claim(ClaimTypes.Role, res.Rola) }, null, DateTime.Now.AddMinutes(30), zaszfrowanyKlucz);
            res.Token = new JwtSecurityTokenHandler().WriteToken(token);
            return res;
        }
    }
}
