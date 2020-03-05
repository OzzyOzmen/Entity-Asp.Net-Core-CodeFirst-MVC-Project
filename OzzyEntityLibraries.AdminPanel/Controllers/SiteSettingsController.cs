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
    public class SiteSettingsController : Controller
    {
        // GET: /<controller>/
        GeneralSettingsServices generalSettingsServices;


        private IHostingEnvironment _hostingEnvironment;

        public SiteSettingsController(IHostingEnvironment hostingEnvironment)
        {

            if (generalSettingsServices == null)
            {
                generalSettingsServices = new GeneralSettingsServices();
            }
            _hostingEnvironment = hostingEnvironment;
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public ActionResult Index()
        {
            var generalSetting = generalSettingsServices.GetAllGeneralSettingsServices().FirstOrDefault();
            if (generalSetting.SiteLogo == null)
            {
                generalSetting.SiteLogo = "resimyok.png ";
            }
            return View(generalSetting);
        }

        [HttpPost]
        public ActionResult Index(GeneralSettingsDTO entity)
        {

            generalSettingsServices.UpdateGeneralSettingsServices(entity);
            //return View(entity);
            return Redirect("/Home");
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ImageUpload(string images)
        {
            var ImageUploadPath = @"/wwwroot/images/uploads/SiteLogo/";
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