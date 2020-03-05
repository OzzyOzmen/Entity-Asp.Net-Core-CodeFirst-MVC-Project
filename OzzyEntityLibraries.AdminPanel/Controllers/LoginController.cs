using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OzzyEntityLibraries.DTO.Models;
using OzzyEntityLibraries.Services;
using Microsoft.AspNetCore.Session;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace OzzyEntityLibraries.AdminPanel.Controllers
{
    public class LoginController : Controller
    {
        AllUsersServices allUsersServices;

        public LoginController()
        {
            if (allUsersServices == null)
            {
                allUsersServices = new AllUsersServices();
            }


        }

        [HttpGet]
        public IActionResult Index()
        {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(string UserName, string UserPassword)
        {
            var users = allUsersServices.GetAllUsersService().Where(x => x.UserName == UserName && x.UserPassword == UserPassword).FirstOrDefault();



            if (users != null)
            {

                string userid = users.UserId.ToString();
                string username = users.UserName;
                string password = users.UserPassword;
                string namesurname = users.NameSurname;
                string userRole = users.UserRole;
                string UserPhoto = users.UserPhoto;
                if (UserPhoto==null)
                {
                    UserPhoto = "~/images/icon/avatar-big-01.png";
                }
                if(UserPhoto != null)
                {
                    UserPhoto = users.UserPhoto;
                }


                var claims = new List<Claim>
                    {
                        new Claim("UserId", users.UserId.ToString()),
                        new Claim("UserName", users.UserName),
                        new Claim("Password", users.UserPassword),
                        new Claim("NameSurname", users.NameSurname),
                        new Claim(ClaimTypes.Role, users.UserRole),
                        new Claim("UserPhoto", users.UserPhoto)



                    };

                var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                          new ClaimsPrincipal(identity),
                          new AuthenticationProperties
                          {
                              ExpiresUtc = DateTime.UtcNow.AddYears(2),
                              IsPersistent = true
                          });


                return RedirectToAction("Index", "Home");

            }

            TempData["LoginMessage"] = "Kullanıcı adı veya şifre yanlış!";

            return View();
        }
    }
}