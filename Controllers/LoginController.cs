using CompanyCore.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Web.Helpers;

namespace CompanyCore.Controllers
{
    public class LoginController : Controller
    {
        Context db = new Context();
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
		public async Task<IActionResult> Login(Admin admin)
		{
            var infos=db.Admins.FirstOrDefault(a=>a.User==admin.User&&
                        a.Password==admin.Password);

            if(infos!=null)
            {
                var claims = new List<Claim>
                {
                     new Claim(ClaimTypes.Name,admin.User)

                };
                var userIdentity=new ClaimsIdentity(claims,"Login");
                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Index","Personel");
            }
			return View();
		}   
	}
}
