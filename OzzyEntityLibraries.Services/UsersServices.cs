using System.Security.Cryptography.X509Certificates;
using System.Linq;
using System.Collections.Generic;
using System;
using OzzyEntityLibraries.Repository;
using OzzyEntityLibraries.DTO.Models;
using OzzyEntityLibraries.ORM.Models;

namespace OzzyEntityLibraries.Services
{
    public class UsersServices
    {

        UsersRepository usersRepository;

        public UsersServices()
        {
            if (usersRepository == null)
            {
                usersRepository = new UsersRepository();
            }
        }

        public IEnumerable<UsersDTO> GetAllUsersServices()
        {
            return usersRepository.GetAll().Select(r => new UsersDTO
            {
                UserId = r.UserId,
                UserRoleId = r.UserRoleId,
                UserName = r.UserName,
                UserPassword = r.UserPassword,
                UserPhoto = r.UserPhoto,
                NameSurname = r.NameSurname,
                IdentityNumber = r.IdentityNumber,
                Phone = r.Phone,
                Email = r.Email,
                TerritoryId = r.TerritoryId,
                RegionId = r.RegionId,
                CountryId = r.CountryId

            }).ToList();
        }

        public void AddNewUsersServices(UsersDTO entity)
        {
            Users users = new Users
            {
               
                UserRoleId = entity.UserRoleId,
                UserName = entity.UserName,
                UserPassword = entity.UserPassword,
                UserPhoto = entity.UserPhoto,
                NameSurname = entity.NameSurname,
                IdentityNumber = entity.IdentityNumber,
                Phone = entity.Phone,
                Email = entity.Email,
                TerritoryId = entity.TerritoryId,
                RegionId = entity.RegionId,
                CountryId = entity.CountryId
            };
            usersRepository.Add(users);
        }

        public void UpdateUsersServices(UsersDTO entity)
        {
            var users = usersRepository.GetAll().Where(r => r.UserId == entity.UserId).FirstOrDefault();
            users.UserRoleId = entity.UserRoleId;
            users.UserName = entity.UserName;
            users.UserPassword = entity.UserPassword;
            users.UserPhoto = entity.UserPhoto;
            users.NameSurname = entity.NameSurname;
            users.IdentityNumber = entity.IdentityNumber;
            users.Phone = entity.Phone;
            users.Email = entity.Email;
            users.TerritoryId = entity.TerritoryId;
            users.RegionId = entity.RegionId;
            users.CountryId = entity.CountryId;

            usersRepository.Update(users);
        }

        public void DeleteUsersServices(UsersDTO entity)
        {
             var users = usersRepository.GetAll().Where(r => r.UserId == entity.UserId).FirstOrDefault();
            users.UserRoleId = entity.UserRoleId;
            users.UserName = entity.UserName;
            users.UserPassword = entity.UserPassword;
            users.UserPhoto = entity.UserPhoto;
            users.NameSurname = entity.NameSurname;
            users.IdentityNumber = entity.IdentityNumber;
            users.Phone = entity.Phone;
            users.Email = entity.Email;
            users.TerritoryId = entity.TerritoryId;
            users.RegionId = entity.RegionId;
            users.CountryId = entity.CountryId;

            usersRepository.Delete(users);
        }

        public bool DeleteUsersServicesbyId(int id)
        {
            return usersRepository.DeletebyEntity(x => x.UserId == id);
        }
    }
}
