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
    public class ReferencesController:Controller
    {
        ReferencesServices referencesServices;
        ReferenceCategoriesServices referenceCategoriesServices;

        private IHostingEnvironment _hostingEnvironment;

        public ReferencesController (IHostingEnvironment hostingEnvironment)
        {
            if (referencesServices==null)
            {
                referencesServices= new ReferencesServices();
            }

            if (referenceCategoriesServices==null)
            {
                referenceCategoriesServices = new ReferenceCategoriesServices();
            }

            _hostingEnvironment = hostingEnvironment;
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult Index()
        {
           var reference= referencesServices.GetAllReferencesService().ToList();
           return View(reference);
        }

        [HttpPost]
        public IActionResult DeleteReferencesByID(int id)
        {
            var reference = referencesServices.DeleteReferencesServiceByID(id);

            return Json(true);
        }

        [HttpGet]
        public IActionResult UpdateReferences(int id)
        {
            var reference = referencesServices.GetAllReferencesService().Where(r => r.ReferenceId == id).FirstOrDefault();

            if (reference.ReferenceLogo == null)
            {
                reference.ReferenceLogo = "resimyok.png ";
            }
            var categories = referenceCategoriesServices.GetAlReferenceCategoriesService().ToList();
            AllReferencesDTO allReferencesDTO = new AllReferencesDTO();
            allReferencesDTO.referencessDTO = reference;
            allReferencesDTO.referenceCategoriesDTO = categories;
            allReferencesDTO.selectedIndex = reference.ReferenceCategoryId;

            return View(allReferencesDTO);
        }

        [HttpPost]
        public IActionResult UpdateReferences(ReferencessDTO entity)
        {
            referencesServices.UpdateReferencesService(entity);
            return Redirect("/References");
        }

        [HttpGet]
        public IActionResult AddNewReferences()
        {
            var referencecategories = referenceCategoriesServices.GetAlReferenceCategoriesService().ToList();

            return View(referencecategories);
        }

        [HttpPost]
        public IActionResult AddNewReferences(ReferencessDTO entity)
        {
            referencesServices.AddNewReferencesService(entity);
            return Redirect("/References");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ImageUpload(string images)
        {
            var ImageUploadPath = @"/wwwroot/images/uploads/References/";
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
