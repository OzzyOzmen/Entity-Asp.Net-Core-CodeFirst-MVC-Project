using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using OzzyEntityLibraries.AdminPanel.Models;
using Microsoft.AspNetCore.Authorization;
using OzzyEntityLibraries.DTO.Models;

namespace OzzyEntityLibraries.AdminPanel.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {

        }


        [Authorize(Roles = "Admin")]
        public IActionResult Index()
        {
            //var user = User.Identity.GetNameSurname();

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }



        
    }
}
