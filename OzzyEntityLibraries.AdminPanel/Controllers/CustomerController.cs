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
    public class CustomerController : Controller
    {
        CustomersService customersService;

        public CustomerController()
        {
            if (customersService==null)
            {
                customersService = new CustomersService();
            }
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult Index()
        {
            var customers = customersService.GetAllCustomers();

            return View(customers);
        }

        [HttpGet]
        public IActionResult AddNewCustomer()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddNewCustomer(CustomersDTO entity)
        {
            customersService.AddCustomers(entity);

            return Redirect("/Customers");
        }
        [HttpGet]
        public IActionResult UpdateCustomer(int id)
        {
            var customer = customersService.GetAllCustomers().Where(r => r.CustomerId == id).FirstOrDefault();
           
            return View(customer);
        }

        [HttpPost]
        public IActionResult UpdateCustomer(CustomersDTO entity)
        {
            customersService.UpdateCustomers(entity);
            return Redirect("/Customers");
        }

        [HttpPost]
        public IActionResult DeleteCustomerByID(int id)
        {
            var customer = customersService.DeleteCustomersById(id);

            return Json(true);
        }

    }
}
