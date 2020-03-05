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
    public class UsersController : Controller
    {
        UsersServices usersServices;

        UserRolesServices userRolesServices;

        TerritoryRegionCountryServices territoryRegionCountryServices;

        private IHostingEnvironment _hostingEnvironment;

        public UsersController(IHostingEnvironment hostingEnvironment)
        {
            if (usersServices == null)
            {
                usersServices = new UsersServices();
            }
            if (userRolesServices==null)
            {
                userRolesServices = new UserRolesServices();
            }
            if (territoryRegionCountryServices == null)
            {
                territoryRegionCountryServices = new TerritoryRegionCountryServices();
            }
            _hostingEnvironment = hostingEnvironment;
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult Index()
        {
            var user = usersServices.GetAllUsersServices().ToList();

            return View(user);
        }

        [HttpGet]
        public IActionResult AddNewUser()
        {
            var userRoles = userRolesServices.GetAllUserRolesServices().ToList();

            var territory = territoryRegionCountryServices.GetTerritoryService().ToList();

            var region = territoryRegionCountryServices.GetRegionService().ToList();

            var country = territoryRegionCountryServices.GetCountryService().ToList();

            AllUserDTO allUserDTO = new AllUserDTO();
            allUserDTO.userRolesDTO = userRoles;
            allUserDTO.territoriesDTOs = territory;
            allUserDTO.regionsDTOs = region;
            allUserDTO.countriesDTOs = country;

            return View(allUserDTO);
        }

        [HttpPost]
        public IActionResult AddNewUser(UsersDTO entity)
        {
            usersServices.AddNewUsersServices(entity);

            return Redirect("/Users");
        }
        [HttpGet]
        public IActionResult UpdateUser(int id)
        {
            var user = usersServices.GetAllUsersServices().Where(r => r.UserId == id).FirstOrDefault();

            var userRoles = userRolesServices.GetAllUserRolesServices().ToList();

            var territory = territoryRegionCountryServices.GetTerritoryService().ToList();

            var region = territoryRegionCountryServices.GetRegionService().ToList();

            var country = territoryRegionCountryServices.GetCountryService().ToList();

            if (user.UserPhoto == null)
            {
                user.UserPhoto = "resimyok.png ";
            }
        
            AllUserDTO allUserDTO = new AllUserDTO();
            allUserDTO.usersDTO = user;
            allUserDTO.userRolesDTO = userRoles;
            allUserDTO.territoriesDTOs = territory;
            allUserDTO.regionsDTOs = region;
            allUserDTO.countriesDTOs = country;
            allUserDTO.selectedIndex = user.UserRoleId;
            allUserDTO.selectedIndex2 = user.TerritoryId;
            allUserDTO.selectedIndex3 = user.RegionId;
            allUserDTO.selectedIndex4 = user.CountryId;

            return View(allUserDTO);
        }

        [HttpPost]
        public IActionResult UpdateUser(UsersDTO entity)
        {
            usersServices.UpdateUsersServices(entity);
            return Redirect("/Users");
        }

        [HttpPost]
        public IActionResult DeleteUserByID(int id)
        {
            var user = usersServices.DeleteUsersServicesbyId(id);

            return Json(true);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ImageUpload(string images)
        {
            var ImageUploadPath = @"/wwwroot/images/uploads/Users/";
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

