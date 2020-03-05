using System;
using System.IO;
using System.Web;
using System.Linq;
using OzzyEntityLibraries.Services;
using OzzyEntityLibraries.DTO.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting.Server;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Authorization;

namespace OzzyEntityLibraries.AdminPanel.Controllers
{
    public class MusterilerController : Controller
    {
        CustomersService customersService;

        public MusterilerController()
        {
            if (customersService == null)
            {
                customersService = new CustomersService();
            }
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult Index()
        {
            var customers = customersService.GetAllCustomers().ToList();

            return View(customers);
        }

        [HttpGet]
        public IActionResult AddNewMusteri()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddNewMusteri(CustomersDTO entity)
        {
            customersService.AddCustomers(entity);

            return Redirect("/Musteriler");
        }
        [HttpGet]
        public IActionResult UpdateMusteri(int id)
        {
            var customer = customersService.GetAllCustomers().Where(r => r.CustomerId == id).FirstOrDefault();

            return View(customer);
        }

        [HttpPost]
        public IActionResult UpdateMusteri(CustomersDTO entity)
        {
            customersService.UpdateCustomers(entity);
            return Redirect("/Musteriler");
        }

        [HttpPost]
        public IActionResult DeleteMusteriByID(int id)
        {
            var customer = customersService.DeleteCustomersById(id);

            return Json(true);
        }
        [HttpGet]
        public IActionResult TopluSmsgonder()
        {
            var customers = customersService.GetAllCustomers().ToList();

            return View(customers);
        }

        //[HttpPost]
        //public IActionResult TopluSmsgonder(SmsSenderDTO entity)
        //{
        //    var id = User.Identity.GetUserId();
        //    var UserName = User.Identity.GetUserName();
        //    var Password = User.Identity.GetPassword();
        //    var NameSurname = User.Identity.GetNameSurname();
        //    var UserRoleId = User.Identity.GetUserRoleId();
        //    var UserCode = entity.UserCode;
        //    var OrginatorTitle = entity.OrginatorTitle;
        //    var Phones = entity.Phone;
        //    var SmsDescription = entity.SmsDescription;
        //    var CharacterType = entity.CharacterType;


        //    VatanSmsServisim.OztekSmsWebService ws = new VatanSmsServisim.OztekSmsWebService();
        //    int sonuc = ws.TekSmsiBirdenCokNumarayaGonder(UserCode, UserName, Password, OrginatorTitle, Phones, SmsDescription, "", "", CharacterType);

        //    if (sonuc > 0)
        //    {
        //        return Redirect("/Musteriler");
        //    }
        //    else
        //    {
        //        return Redirect("/Musteriler/TopluSmsGonder");
        //    }
        //}

    }
}
