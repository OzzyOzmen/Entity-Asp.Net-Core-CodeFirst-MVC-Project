using System.Security.Cryptography.X509Certificates;
using System.Linq;
using System.Collections.Generic;
using System;
using OzzyEntityLibraries.DTO.Models;
using OzzyEntityLibraries.Repository;
using OzzyEntityLibraries.ORM.Models;

namespace OzzyEntityLibraries.Services
{
    public class NewsLettersServices
    {

        NewsLettersRepository newsLettersRepository;

        public NewsLettersServices()
        {
            if (newsLettersRepository==null)
            {
                newsLettersRepository = new NewsLettersRepository();
            }
        }

        public IEnumerable<NewslettersDTO> GetAllNewsLettersService()
        {
            return newsLettersRepository.GetAll().Select(r=> new NewslettersDTO
            {
                  NewsletterId=r.NewsletterId,
                  Email=r.Email

            }).ToList();
        }

        public void AddNewsLetterService(NewslettersDTO entity)
        {
            Newsletters newsletters = new  Newsletters
            {
                 Email=entity.Email
            };

            newsLettersRepository.Add(newsletters);
        }

        public void UpdateNewsLetterService(NewslettersDTO entity)
        {
            var newsletter=newsLettersRepository.GetAll().Where(X=>X.NewsletterId==entity.NewsletterId).FirstOrDefault();
            newsletter.Email=entity.Email;
            newsLettersRepository.Update(newsletter);
        }

        public void DeleteNewsLetterService(NewslettersDTO entity)
        {
           var newsletter=newsLettersRepository.GetAll().Where(X=>X.NewsletterId==entity.NewsletterId).FirstOrDefault();
            newsletter.Email=entity.Email;
            newsLettersRepository.Delete(newsletter); 
        }

        public bool DeleteNewsLetterServiceByID(int id)
        {
            return newsLettersRepository.DeletebyEntity(r=>r.NewsletterId==id);
        }

    }
}
