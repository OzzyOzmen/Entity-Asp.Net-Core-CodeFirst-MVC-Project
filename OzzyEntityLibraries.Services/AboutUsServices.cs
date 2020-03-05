using System.Linq;
using System.Collections.Generic;
using System.Collections;
using System;
using OzzyEntityLibraries.Repository;
using OzzyEntityLibraries.DTO.Models;
using OzzyEntityLibraries.ORM.Models;

namespace OzzyEntityLibraries.Services
{
    public class AboutUsServices
    {

       AboutUsRepository aboutUsRepository;

       public AboutUsServices()
       {
           if (aboutUsRepository==null)
           {
               
               aboutUsRepository = new AboutUsRepository();
           }
       }

          public IEnumerable<AboutUsDTO> GetAboutUsService()
          {
                return aboutUsRepository.GetAll().Select(x=> new AboutUsDTO
                {
                  AboutUsId=x.AboutUsId,
                  AboutUsTitle=x.AboutUsTitle,
                  AboutUsDescription=x.AboutUsDescription,
                  Photo=x.Photo

                }).ToList();
          }
             
          public void AddAboutUsService(AboutUsDTO entity)
          {
              AboutUs aboutUs = new AboutUs
              {
                 AboutUsTitle=entity.AboutUsTitle,
                 AboutUsDescription=entity.AboutUsDescription,
                 Photo=entity.Photo

              };
              aboutUsRepository.Add(aboutUs);
          }

          public void UpdateAboutUsService(AboutUsDTO entity)
          {
            var result=aboutUsRepository.GetAll().Where(r=>r.AboutUsId==entity.AboutUsId).FirstOrDefault();
            result.AboutUsTitle=entity.AboutUsTitle;
            result.AboutUsDescription=entity.AboutUsDescription;
            result.Photo=entity.Photo;
            aboutUsRepository.Update(result); 
          }

          public void DeleteAboutUsService(AboutUsDTO entity)
          {
            var result=aboutUsRepository.GetAll().Where(r=>r.AboutUsId==entity.AboutUsId).FirstOrDefault();
            result.AboutUsTitle=entity.AboutUsTitle;
            result.AboutUsDescription=entity.AboutUsDescription;
            result.Photo=entity.Photo;
            aboutUsRepository.Delete(result);   
          }

          public bool DeleteAboutUsServiceByID(int id)
          {
              return aboutUsRepository.DeletebyEntity(r=>r.AboutUsId==id);  
          
              
          }

    }
}
