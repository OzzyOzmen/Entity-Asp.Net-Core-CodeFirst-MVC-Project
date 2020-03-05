using System.Linq;
using System.Collections.Generic;
using System;
using OzzyEntityLibraries.Repository;
using OzzyEntityLibraries.DTO.Models;
using OzzyEntityLibraries.ORM.Models;

namespace OzzyEntityLibraries.Services
{
    public class ReferenceCategoriesServices
    {
        ReferenceCategoriesRepository  referenceCategoriesRepository;

        public ReferenceCategoriesServices()
        {
            if (referenceCategoriesRepository==null)
            {
                referenceCategoriesRepository=new ReferenceCategoriesRepository();
            }
        }

        public IEnumerable<ReferenceCategoriesDTO> GetAlReferenceCategoriesService()
        {
            return referenceCategoriesRepository.GetAll().Select(x=> new ReferenceCategoriesDTO
            {
                ReferenceCategoryId=x.ReferenceCategoryId,
                ReferenceCategoryName=x.ReferenceCategoryName

            }).ToList();

        }

       public void AddNewReferenceCategoriesService(ReferenceCategoriesDTO entity)
       {
           ReferenceCategories referenceCategories = new ReferenceCategories
           {
               ReferenceCategoryName=entity.ReferenceCategoryName
           };
           referenceCategoriesRepository.Add(referenceCategories);
       }

       public void UpdateReferenceCategoriesService(ReferenceCategoriesDTO entity)
       {
           var referenceCategories = referenceCategoriesRepository.GetAll().Where(x=>x.ReferenceCategoryId==entity.ReferenceCategoryId).FirstOrDefault();
           referenceCategories.ReferenceCategoryName=entity.ReferenceCategoryName;

           referenceCategoriesRepository.Update(referenceCategories);
       }

       public void DeleteReferenceCategoriesService(ReferenceCategoriesDTO entity)
       {
           var referenceCategories = referenceCategoriesRepository.GetAll().Where(x=>x.ReferenceCategoryId==entity.ReferenceCategoryId).FirstOrDefault();
           referenceCategories.ReferenceCategoryName=entity.ReferenceCategoryName;

           referenceCategoriesRepository.Delete(referenceCategories);
       }

       public bool DeleteReferenceCategoriesServiceByID(int id)
       {
           return referenceCategoriesRepository.DeletebyEntity(r=>r.ReferenceCategoryId==id);
       }
    }
}
