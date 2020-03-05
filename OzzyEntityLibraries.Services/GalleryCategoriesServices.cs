using System.Security.Cryptography.X509Certificates;
using System.Linq;
using System.Collections.Generic;
using System.Collections;
using System;
using OzzyEntityLibraries.Repository;
using OzzyEntityLibraries.DTO.Models;
using OzzyEntityLibraries.ORM.Models;

namespace OzzyEntityLibraries.Services
{
    public class GalleryCategoriesServices
    {
       GalleryCategoriesRepository galleryCategoriesRepository;

       public GalleryCategoriesServices()
       {
           if (galleryCategoriesRepository==null)
           {
               galleryCategoriesRepository=new GalleryCategoriesRepository();
           }
       }

       public IEnumerable<GalleryCategoriesDTO> GetAllGalleryCategoriesService()
       {
           return galleryCategoriesRepository.GetAll().Select(x=> new GalleryCategoriesDTO
           {

             GalleryCategoryId=x.GalleryCategoryId,
             GalleryCategoryName=x.GalleryCategoryName,
             GalleryCategoryPhoto=x.GalleryCategoryPhoto

           }).ToList();
       }

       public void AddGalleryCategoriesService(GalleryCategoriesDTO entity)
       {

            GalleryCategories galleryCategories = new GalleryCategories
            {
                GalleryCategoryName=entity.GalleryCategoryName,
                GalleryCategoryPhoto=entity.GalleryCategoryPhoto

            };

            galleryCategoriesRepository.Add(galleryCategories);
        }

        public void UpdateGalleryCategoriesService(GalleryCategoriesDTO entity)
        {
              var galleryCategories= galleryCategoriesRepository.GetAll().Where(r=>r.GalleryCategoryId==entity.GalleryCategoryId).FirstOrDefault();
              galleryCategories.GalleryCategoryName=entity.GalleryCategoryName;
              galleryCategories.GalleryCategoryPhoto=entity.GalleryCategoryPhoto;

              galleryCategoriesRepository.Update(galleryCategories);

        }

        public void DeleteGalleryCategoriesService(GalleryCategoriesDTO entity)
        {
           var galleryCategories= galleryCategoriesRepository.GetAll().Where(r=>r.GalleryCategoryId==entity.GalleryCategoryId).FirstOrDefault();
              galleryCategories.GalleryCategoryName=entity.GalleryCategoryName;
              galleryCategories.GalleryCategoryPhoto=entity.GalleryCategoryPhoto;

              galleryCategoriesRepository.Delete(galleryCategories);

        }

        public bool DeleteGalleryCategoriesServiceByID(int id)
        {
           return galleryCategoriesRepository.DeletebyEntity(x=>x.GalleryCategoryId==id );
        }
    }
}
