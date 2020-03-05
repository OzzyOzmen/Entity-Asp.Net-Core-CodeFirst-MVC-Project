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

namespace OzzyEntityLibraries.AdminPanel.Views.Hizmetler
{
    public class HizmetlerController : Controller
    {
        Services.Services services;

        private IHostingEnvironment _hostingEnvironment;

        public HizmetlerController(IHostingEnvironment hostingEnvironment)
        {
            if (services == null)
            {
                services = new Services.Services();
            }
            _hostingEnvironment = hostingEnvironment;
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult Index()
        {
            var service = services.GetAllServices().ToList();
            return View(service);
        }

        [HttpGet]
        public IActionResult AddNewHizmet()
        {
           return View();
        }

        [HttpPost]
        public IActionResult AddNewHizmet(ServicesDTO entity)
        {
           services.AddNewServices(entity);

            return Redirect("/Hizmetler");
        }
        [HttpGet]
        public IActionResult UpdateHizmet(int id)
        {
            var service = services.GetAllServices().Where(r => r.ServiceId == id).FirstOrDefault();
            if (service.Photo == null)
            {
                service.Photo = "resimyok.png ";
            }

            return View(service);
        }

        [HttpPost]
        public IActionResult UpdateHizmet(ServicesDTO entity)
        {
            services.UpdateServices(entity);
            return Redirect("/Hizmetler");
        }

        [HttpPost]
        public IActionResult DeleteHizmetByID(int id)
        {
            var service = services.DeleteServicesById(id);

            return Json(true);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ImageUpload(string images)
        {
            var ImageUploadPath = @"/wwwroot/images/uploads/Hizmetler/";
            var imgUrls = "";
            string[] test = new string[Request.Form.Files.Count];
            for (int i = 0; i < Request.Form.Files.Count; i++)
            {

                var file = Request.Form.Files[i];
                var fileName = Path.GetFileName(file.FileName);

                var tamyol = _hostingEnvironment.ContentRootPath + ImageUploadPath + fileName;
                using (var fs = new FileStream(tamyol, FileMode.Create))
                {
                    file.CopyTo(fs);
                    fs.Close();
                    test[i] = file.FileName;
                }

            }

            for (int j = 0; j < test.Length; j++)
            {
                imgUrls += test[j] + ",";


            }
            //tüm resimler isim->

            var result = "";
            string imgUrl = imgUrls.Substring(0, imgUrls.Length - 1);
            if (images!=null)
            {
                images = images.Trim(',');
                result = images.ToString() + "," + imgUrl;
            }
            else
            {
                 result = imgUrl.Trim(',');
            }

            return Json(result);

        }

        
    }
}