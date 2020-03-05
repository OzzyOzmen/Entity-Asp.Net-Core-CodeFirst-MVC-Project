using System.Linq;
using System.Collections.Generic;
using System.Collections;
using System;
using OzzyEntityLibraries.Repository;
using OzzyEntityLibraries.DTO.Models;
using OzzyEntityLibraries.ORM.Models;

namespace OzzyEntityLibraries.Services
{
    public class AllCustomersServices
    {
        AllCustomersRepository allCustomersRepository;

        public AllCustomersServices()
        {
            if (allCustomersRepository == null)
            {
                allCustomersRepository = new AllCustomersRepository();
            }
        }

        public IEnumerable<AllCustomersDTO> GetAllCustomersService()
        {
            return allCustomersRepository.GetAll().Select(x => new AllCustomersDTO
            {
                CustomerId=x.CustomerId,
                Address=x.Address,
                CompanyName=x.CompanyName,
                ContactName=x.ContactName,
                ContactTitle=x.ContactTitle,
                CountryName=x.CountryName,
                Email=x.Email,
                Fax=x.Fax,
                Phone=x.Phone,
                PostalCode=x.PostalCode,
                RegionName=x.RegionName,
                TerritoryName=x.TerritoryName

            }).ToList();
        }


        // There is no any Add, Update or Delete methods for View 
    }
}
