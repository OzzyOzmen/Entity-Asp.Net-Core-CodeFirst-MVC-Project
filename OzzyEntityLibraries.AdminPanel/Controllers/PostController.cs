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
    public class PostController : Controller
    {

        PostsServices postsServices;
        PostCategoriesServices postCategoriesServices;

        private IHostingEnvironment _hostingEnvironment;

        public PostController(IHostingEnvironment hostingEnvironment)
        {
            if (postsServices == null)
            {
                postsServices = new PostsServices();
            }

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
            var post = postsServices.GetAllPostsService().ToList();
            return View(post);
        }

        [HttpPost]
        public IActionResult DeletePostByID(int id)
        {
            var post = postsServices.DeletePostsServiceById(id);

            return Json(true);
        }

        [HttpGet]
        public IActionResult UpdatePost(int id)
        {
            var post = postsServices.GetAllPostsService().Where(r => r.PostId == id).FirstOrDefault();
            if (post.PostPhoto == null)
            {
                post.PostPhoto = "resimyok.png ";
            }
            var categories = postCategoriesServices.GetAllPostCategoriesService().ToList();
            AllPostsDTO allPostsDTO = new AllPostsDTO();
            allPostsDTO.postsDTO = post;
            allPostsDTO.postCategoriesDTOs = categories;
            allPostsDTO.selectedIndex = post.PostCategoryId;

            return View(allPostsDTO);
        }

        [HttpPost]
        public IActionResult UpdatePost(PostsDTO entity)
        {
            postsServices.UpdatePostsService(entity);
            return Redirect("/Post");
        }

        [HttpGet]
        public IActionResult AddNewPost()
        {
            var postCategories = postCategoriesServices.GetAllPostCategoriesService().ToList();

            return View(postCategories);
        }

        [HttpPost]
        public IActionResult AddNewPost(PostsDTO entity)
        {
            postsServices.AddPostsService(entity);
            return Redirect("/Post");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ImageUpload(string images)
        {
            var ImageUploadPath = @"/wwwroot/images/uploads/Post/";
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
