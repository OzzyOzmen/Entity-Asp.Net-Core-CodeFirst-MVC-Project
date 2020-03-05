using System.Linq;
using System.Collections.Generic;
using System.Collections;
using System;
using OzzyEntityLibraries.Repository;
using OzzyEntityLibraries.DTO.Models;
using OzzyEntityLibraries.ORM.Models;

namespace OzzyEntityLibraries.Services
{
    public class AllUsersServices
    {
         AllUsersRepository allUsersRepository;

        public AllUsersServices()
        {
            if (allUsersRepository == null)
            {
                allUsersRepository = new AllUsersRepository();
            }
        }

        public IEnumerable<AllUsersDTO> GetAllUsersService()
        {
            return allUsersRepository.GetAll().Select(x => new AllUsersDTO
            {
                UserId = x.UserId,
                CountryName = x.CountryName,
                Email = x.Email,
                IdentityNumber = x.IdentityNumber,
                NameSurname=x.NameSurname,
                Phone = x.Phone,
                RegionName=x.RegionName,
                TerritoryName=x.TerritoryName,
                UserName=x.UserName,
                UserPassword=x.UserPassword,
                UserPhoto=x.UserPhoto,
                UserRole=x.UserRole

            }).ToList();
        }


        // There is no any Add, Update or Delete methods for View 
    }
}
