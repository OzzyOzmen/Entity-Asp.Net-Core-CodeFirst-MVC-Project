using System.Linq;
using OzzyEntityLibraries.Services;
using OzzyEntityLibraries.DTO.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace OzzyEntityLibraries.AdminPanel.Controllers
{
    public class ReferenceCategoryController : Controller
    {

        ReferenceCategoriesServices referenceCategoriesServices;

        public ReferenceCategoryController()
        {
            if (referenceCategoriesServices==null)
            {
                referenceCategoriesServices = new ReferenceCategoriesServices();
            }
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult Index()
        {
            var referencecategory = referenceCategoriesServices.GetAlReferenceCategoriesService().ToList();
            return View(referencecategory);
        }

        [HttpPost]
        public IActionResult Index(ReferenceCategoriesDTO entity)
        {
            referenceCategoriesServices.AddNewReferenceCategoriesService(entity);

            return Redirect("/ReferenceCategory");
        }
        [HttpPost]
        public IActionResult DeleteReferenceCategory(int id)
        {
           var referencecategory= referenceCategoriesServices.DeleteReferenceCategoriesServiceByID(id);

           return Json(true);
           
        }
       /* [HttpPost]
        public IActionResult UpdateReferenceCategory(int id)
        {
            var referencecategories = referenceCategoriesServices.GetAlReferenceCategoriesService().Where(x => x.ReferenceCategoryId == id).FirstOrDefault();

            return Redirect("/ReferenceCategories");
        }
        */
        [HttpPost]
        public IActionResult UpdateReferenceCategory(ReferenceCategoriesDTO entity)
        {
           referenceCategoriesServices.UpdateReferenceCategoriesService(entity);

            return Redirect("/ReferenceCategory");

        }



    }
}
