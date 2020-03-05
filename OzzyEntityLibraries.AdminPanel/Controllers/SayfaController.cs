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
    public class SayfaController : Controller
    {
        PagesServices pagesServices;

        private IHostingEnvironment _hostingEnvironment;

        public SayfaController(IHostingEnvironment hostingEnvironment)
        {
            if (pagesServices == null)
            {
                pagesServices = new PagesServices();
            }
            _hostingEnvironment = hostingEnvironment;
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult Index()
        {
            var page = pagesServices.GetAllPagesService().ToList();
            return View(page);
        }

        [HttpGet]
        public IActionResult AddNewSayfa()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddNewSayfa(PagesDTO entity)
        {
            pagesServices.AddPagesService(entity);

            return Redirect("/Sayfa");
        }
        [HttpGet]
        public IActionResult UpdateSayfa(int id)
        {
            var page = pagesServices.GetAllPagesService().Where(r => r.PageId == id).FirstOrDefault();

            if (page.Photo == null)
            {
                page.Photo = "resimyok.png ";
            }
            return View(page);
        }

        [HttpPost]
        public IActionResult UpdateSayfa(PagesDTO entity)
        {
            
            pagesServices.UpadatePagesService(entity);
            return Redirect("/Sayfa");
        }

        [HttpPost]
        public IActionResult DeleteSayfaByID(int id)
        {
            var page = pagesServices.DeletePagesServiceByID(id);

            return Json(true);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ImageUpload(string images)
        {
            var ImageUploadPath = @"/wwwroot/images/uploads/Page/";
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
            if (images != null)
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