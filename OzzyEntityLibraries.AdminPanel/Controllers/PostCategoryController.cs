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
    public class PostCategoryController : Controller
    {
        PostCategoriesServices postCategoriesServices;

        private IHostingEnvironment _hostingEnvironment;

        public PostCategoryController(IHostingEnvironment hostingEnvironment)
        {
            if (postCategoriesServices == null)
            {
                postCategoriesServices = new PostCategoriesServices();
            }
            _hostingEnvironment = hostingEnvironment;

        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult Index()
        {
            var postCategory = postCategoriesServices.GetAllPostCategoriesService().ToList();
            return View(postCategory);
        }

        [HttpPost]
        public IActionResult Index(PostCategoriesDTO entity)
        {
            postCategoriesServices.AddPostCategoriesService(entity);

            return Redirect("/PostCategory");

        }
        [HttpPost]
        public IActionResult DeletePostCategory(int id)
        {
            var postCategory = postCategoriesServices.DeletePostCategoriesServiceByID(id);

            return Json(true);

        }
        /*
        [HttpPost]
        public IActionResult UpdatePostCategoryCategory(int id)
        {
            var postCategory = postCategoriesServices.GetAllPostCategoriesService().Where(x => x.PostCategoryId == id).FirstOrDefault();

            return Redirect("/PostCategory");
        }
        */
        [HttpPost]
        public IActionResult UpdatePostCategory(PostCategoriesDTO entity)
        {
            postCategoriesServices.UpdatePostCategoriesService(entity);

            return Redirect("/PostCategory");

        }

        [HttpPost]

        public ActionResult ImageUpload()
        {
            var ImageUploadPath = @"/wwwroot/images/uploads/PostCategory/";
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
