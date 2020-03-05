using System.Linq;
using System.Collections.Generic;
using System;
using OzzyEntityLibraries.Repository;
using OzzyEntityLibraries.DTO.Models;
using OzzyEntityLibraries.ORM.Models;

namespace OzzyEntityLibraries.Services
{
    public class ReferencesServices
    {

       ReferencesRepository referencesRepository;

       public ReferencesServices()
       {
           if (referencesRepository==null)
           {
               referencesRepository= new ReferencesRepository();
           }
       }

       public IEnumerable<ReferencessDTO> GetAllReferencesService()
       {
           return referencesRepository.GetAll().Select(x=> new ReferencessDTO
           {
                ReferenceId=x.ReferenceId,
                ReferenceCategoryId=x.ReferenceCategoryId,
                ReferenceName=x.ReferenceName,
                ReferenceDescription=x.ReferenceDescription,
                ReferenceLogo=x.ReferenceLogo

           }).ToList();
       }


        public void AddNewReferencesService(ReferencessDTO entity)
       {
           Referencess referencess = new Referencess
           {
               ReferenceCategoryId=entity.ReferenceCategoryId,
               ReferenceName=entity.ReferenceName,
               ReferenceDescription=entity.ReferenceDescription,
               ReferenceLogo=entity.ReferenceLogo
           };
           referencesRepository.Add(referencess);
       }

       public void UpdateReferencesService(ReferencessDTO entity)
       {
           var referencessservice=referencesRepository.GetAll().Where(x=>x.ReferenceId==entity.ReferenceId).FirstOrDefault();
           referencessservice.ReferenceCategoryId=entity.ReferenceCategoryId;
           referencessservice.ReferenceName=entity.ReferenceName;
           referencessservice.ReferenceDescription=entity.ReferenceDescription;
           referencessservice.ReferenceLogo=entity.ReferenceLogo;

           referencesRepository.Update(referencessservice);
       }

       public void DeleteReferencesService(ReferencessDTO entity)
       {
           var referencessservice=referencesRepository.GetAll().Where(x=>x.ReferenceId==entity.ReferenceId).FirstOrDefault();
           referencessservice.ReferenceCategoryId=entity.ReferenceCategoryId;
           referencessservice.ReferenceName=entity.ReferenceName;
           referencessservice.ReferenceDescription=entity.ReferenceDescription;
           referencessservice.ReferenceLogo=entity.ReferenceLogo;

           referencesRepository.Delete(referencessservice);
       }

       public bool DeleteReferencesServiceByID(int id)
       {
           return referencesRepository.DeletebyEntity(r=>r.ReferenceId==id);
       }

    }
}
