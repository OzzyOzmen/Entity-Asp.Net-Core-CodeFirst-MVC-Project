using System;
using System.Linq;
using System.Collections.Generic;
using OzzyEntityLibraries.Repository;
using OzzyEntityLibraries.DTO.Models;
using OzzyEntityLibraries.ORM.Models;

namespace OzzyEntityLibraries.Services
{
    public class Services
    {
        ServicesRepository servicesRepository;

        public Services()
        {
            if (servicesRepository==null)
            {
                servicesRepository=new ServicesRepository();
            }
        }

       
         public IEnumerable<ServicesDTO> GetAllServices()
        {
            return servicesRepository.GetAll().Select(x=> new ServicesDTO
            {
                ServiceId=x.ServiceId,
                ServiceTitle=x.ServiceTitle,
                ServiceDescription=x.ServiceDescription,
                Photo=x.Photo
            }).ToList();
        }

        public void AddNewServices(ServicesDTO entity)
        {
            Service service = new Service
            {
                ServiceTitle=entity.ServiceTitle,
                ServiceDescription=entity.ServiceDescription,
                Photo=entity.Photo
            };
            servicesRepository.Add(service);
        }

        public void UpdateServices(ServicesDTO entity)
        {
            var service = servicesRepository.GetAll().Where(x=>x.ServiceId==entity.ServiceId).FirstOrDefault();
            service.ServiceTitle=entity.ServiceTitle;
            service.ServiceDescription=entity.ServiceDescription;
            service.Photo=entity.Photo;

            servicesRepository.Update(service);
        }

        public void DeleteServices(ServicesDTO entity)
        {
            var service = servicesRepository.GetAll().Where(x=>x.ServiceId==entity.ServiceId).FirstOrDefault();
            service.ServiceTitle=entity.ServiceTitle;
            service.ServiceDescription=entity.ServiceDescription;
            service.Photo=entity.Photo;

            servicesRepository.Delete(service);
        }

        public bool DeleteServicesById(int id)
        {
            return servicesRepository.DeletebyEntity(x=>x.ServiceId==id);
        }

    }
}
