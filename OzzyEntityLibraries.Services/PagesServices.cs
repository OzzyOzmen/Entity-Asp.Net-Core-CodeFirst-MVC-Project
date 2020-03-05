using System.Linq;
using System.Collections.Generic;
using System.Reflection;
using System;
using OzzyEntityLibraries.Repository;
using OzzyEntityLibraries.DTO.Models;
using OzzyEntityLibraries.ORM.Models;

namespace OzzyEntityLibraries.Services
{
    public class PagesServices
    {

       PagesRepository pagesRepository;

       public PagesServices()
       {
           if (pagesRepository==null)
           {
               pagesRepository=new PagesRepository();
           }
       }

       public IEnumerable<PagesDTO> GetAllPagesService()
       {
           return pagesRepository.GetAll().Select(x=> new PagesDTO
           {
                PageId=x.PageId,
                Pagetitle=x.Pagetitle,
                PageDescription=x.PageDescription,
                Photo=x.Photo,
                PageUrl=x.PageUrl

           }).ToList();
       }

       public void AddPagesService(PagesDTO entity)
       {
           Pages pages = new Pages
           {
               Pagetitle=entity.Pagetitle,
               PageDescription=entity.PageDescription,
               Photo=entity.Photo,
               PageUrl=entity.PageUrl
           };
            pagesRepository.Add(pages);
       }

       public void UpadatePagesService(PagesDTO entity)
       {
           var pages = pagesRepository.GetAll().Where(r=>r.PageId==entity.PageId).FirstOrDefault();
           pages.Pagetitle=entity.Pagetitle;
           pages.PageDescription=entity.PageDescription;
           pages.Photo=entity.Photo;
           pages.PageUrl=entity.PageUrl;

           pagesRepository.Update(pages);
       }

       public void DeletePagesService(PagesDTO entity)
       {
           var pages = pagesRepository.GetAll().Where(r=>r.PageId==entity.PageId).FirstOrDefault();
           pages.Pagetitle=entity.Pagetitle;
           pages.PageDescription=entity.PageDescription;
           pages.Photo=entity.Photo;
           pages.PageUrl=entity.PageUrl;

           pagesRepository.Delete(pages);
       }
        
        public bool DeletePagesServiceByID(int id)
        {
            return pagesRepository.DeletebyEntity(r=>r.PageId==id);
        }

    }
}
