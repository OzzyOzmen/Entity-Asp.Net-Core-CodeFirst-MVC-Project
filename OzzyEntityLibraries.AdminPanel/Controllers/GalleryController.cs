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
    public class GalleryController : Controller
    {

        GalleriesServices galleriesServices;

        GalleryCategoriesServices galleryCategoriesServices;

        private IHostingEnvironment _hostingEnvironment;

        public GalleryController(IHostingEnvironment hostingEnvironment)
        {
            if (galleriesServices == null)
            {
                galleriesServices = new GalleriesServices();
            }

            if (galleryCategoriesServices==null)
            {
                galleryCategoriesServices = new GalleryCategoriesServices();
            }

            _hostingEnvironment = hostingEnvironment;

        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult Index()
        {
            var gallery = galleriesServices.GetAllGalleriesService().ToList();
            return View(gallery);
        }

        [HttpPost]
        public IActionResult DeleteGalleryByID(int id)
        {
            var gallery = galleriesServices.DeleteGalleryServiceByID(id);

            return Json(true);
        }

        [HttpGet]
        public IActionResult UpdateGallery(int id)
        {
            var gallery = galleriesServices.GetAllGalleriesService().Where(r => r.GalleryId == id).FirstOrDefault();
            if (gallery.GalleryPhoto == null)
            {
                gallery.GalleryPhoto = "resimyok.png ";
            }
            var categories = galleryCategoriesServices.GetAllGalleryCategoriesService().ToList();
            AllGalleryDTO allGalleryDTO = new AllGalleryDTO();
            allGalleryDTO.galleriesDTO = gallery;
            allGalleryDTO.galleryCategoriesDTOs = categories;
            allGalleryDTO.selectedIndex = gallery.GalleryCategoryId;

            return View(allGalleryDTO);
        }

        [HttpPost]
        public IActionResult UpdateGallery(GalleriesDTO entity)
        {
            galleriesServices.UpdateGalleryService(entity);
            return Redirect("/Gallery");
        }

        [HttpGet]
        public IActionResult AddNewGallery()
        {
            var galerryCategory = galleryCategoriesServices.GetAllGalleryCategoriesService().ToList();

            return View(galerryCategory);
        }

        [HttpPost]
        public IActionResult AddNewGallery(GalleriesDTO entity)
        {
            galleriesServices.AddGalleryService(entity);
            return Redirect("/Gallery");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ImageUpload(string images)
        {
            var ImageUploadPath = @"/wwwroot/images/uploads/Gallery/";
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
