using System.Linq;
using System.Collections.Generic;
using System.Collections;
using System;
using OzzyEntityLibraries.Repository;
using OzzyEntityLibraries.DTO.Models;
using OzzyEntityLibraries.ORM.Models;
namespace OzzyEntityLibraries.Services
{
    public class AllEmployeesServices
    {
        AllEmployeesRepository allEmployeesRepository;

        public AllEmployeesServices()
        {
            if (allEmployeesRepository == null)
            {
                allEmployeesRepository = new AllEmployeesRepository();
            }
        }

        public IEnumerable<AllEmployeesDTO> GetAllEmployeesService()
        {
            return allEmployeesRepository.GetAll().Select(x => new AllEmployeesDTO
            {
                EmployeeId = x.EmployeeId,
                Birthday = x.Birthday,
                CountryName = x.CountryName,
                Email = x.Email,
                HireDate = x.HireDate,
                IdentityNumber = x.IdentityNumber,
                NameSurname=x.NameSurname,
                Phone=x.Phone,
                RegionName=x.RegionName,
                TerritoryName=x.TerritoryName,
                Title=x.Title,
                UserPhoto=x.UserPhoto

            }).ToList();
        }


        // There is no any Add, Update or Delete methods for View 
    }
}
