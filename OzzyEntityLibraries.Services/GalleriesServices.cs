using System.Linq;
using System.Collections.Generic;
using System;
using OzzyEntityLibraries.Repository;
using OzzyEntityLibraries.DTO.Models;
using OzzyEntityLibraries.ORM.Models;

namespace OzzyEntityLibraries.Services
{
    public class GalleriesServices
    {
        GalleriesRepository galleriesRepository;

        public GalleriesServices()
        {
           if (galleriesRepository==null)
           {
               galleriesRepository= new GalleriesRepository();
           }

        }
        
        public IEnumerable<GalleriesDTO> GetAllGalleriesService()
        {
             return galleriesRepository.GetAll().Select(x=> new GalleriesDTO
             {
                   GalleryId=x.GalleryId,
                   GalleryCategoryId=x.GalleryCategoryId,
                   GalleryName=x.GalleryName,
                   GalleryPhoto=x.GalleryPhoto

             }).ToList();

        }

        public void AddGalleryService(GalleriesDTO entity)
        {
             Galleries galleries = new Galleries
             {
                 
               GalleryCategoryId=entity.GalleryCategoryId,
               GalleryName=entity.GalleryName,
               GalleryPhoto=entity.GalleryPhoto

             };

             galleriesRepository.Add(galleries);

        }

        public void UpdateGalleryService(GalleriesDTO entity)
        {
            var gallery = galleriesRepository.GetAll().Where(x=>x.GalleryId==entity.GalleryId).FirstOrDefault();
            gallery.GalleryCategoryId=entity.GalleryCategoryId;
            gallery.GalleryName=entity.GalleryName;
            gallery.GalleryPhoto=entity.GalleryPhoto;

            galleriesRepository.Update(gallery);
        }

        public void DeleteGalleryService(GalleriesDTO entity)
        {
            var gallery = galleriesRepository.GetAll().Where(x=>x.GalleryId==entity.GalleryId).FirstOrDefault();
            gallery.GalleryCategoryId=entity.GalleryCategoryId;
            gallery.GalleryName=entity.GalleryName;
            gallery.GalleryPhoto=entity.GalleryPhoto;

            galleriesRepository.Delete(gallery);
        }

        public bool DeleteGalleryServiceByID(int id)
        {
             return galleriesRepository.DeletebyEntity(x=>x.GalleryId==id);
        }

    }
}
