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
    public class GalleryCategoryController : Controller
    {

        GalleryCategoriesServices galleryCategoriesServices;

        private IHostingEnvironment _hostingEnvironment;

        public GalleryCategoryController(IHostingEnvironment hostingEnvironment)
        {
            if (galleryCategoriesServices == null)
            {
                galleryCategoriesServices = new GalleryCategoriesServices();
            }
            _hostingEnvironment = hostingEnvironment;

        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult Index()
        {
            var galleryCategory = galleryCategoriesServices.GetAllGalleryCategoriesService().ToList();

            return View(galleryCategory);
        }

        [HttpPost]
        public IActionResult Index(GalleryCategoriesDTO entity)
        {
            galleryCategoriesServices.AddGalleryCategoriesService(entity);

            return Redirect("/GalleryCategory");

        }
        [HttpPost]
        public IActionResult DeleteGalleryCategory(int id)
        {
            var galleryCategory = galleryCategoriesServices.DeleteGalleryCategoriesServiceByID(id);

            return Json(true);

        }
         /*[HttpPost]
         public IActionResult UpdateGalleryCategoryCategory(int id)
         {
             var galleryCategory = galleryCategoriesServices.GetAllGalleryCategoriesService().Where(x => x.GalleryCategoryId == id).FirstOrDefault();

             return Redirect("/ReferenceCategories");
         }
         */
        [HttpPost]
        public IActionResult UpdateGalleryCategory(GalleryCategoriesDTO entity)
        {
            galleryCategoriesServices.UpdateGalleryCategoriesService(entity);

            return Redirect("/GalleryCategory");

        }

        [HttpPost]

        public ActionResult ImageUpload()
        {
            var ImageUploadPath = @"/wwwroot/images/uploads/GalleryCategory/";
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
            string imgUrl = imgUrls.Substring(0, imgUrls.Length - 1);
            return Json(imgUrl);

        }

    }
}
