using System.Linq;
using System.Collections.Generic;
using System;
using OzzyEntityLibraries.Repository;
using OzzyEntityLibraries.DTO.Models;
using OzzyEntityLibraries.ORM.Models;

namespace OzzyEntityLibraries.Services
{
    public class UserRolesServices
    {
        UserRolesRepository userRolesRepository;

        public UserRolesServices()
        {
            if (userRolesRepository==null)
            {
                userRolesRepository=new UserRolesRepository();
            }
        }
        
        public IEnumerable<UserRolesDTO>  GetAllUserRolesServices()
        {
             return userRolesRepository.GetAll().Select(r=> new UserRolesDTO
             {
                 UserRoleId=r.UserRoleId,
                 UserRole=r.UserRole

             }).ToList();
        }

        public void AddNewUserRolesServices(UserRolesDTO entity)
        {
            UserRoles userRoles = new UserRoles
            {
               UserRole=entity.UserRole
            };
            userRolesRepository.Add(userRoles);
        }

        public void UpdateUserRolesServices(UserRolesDTO entity)
        {
            var userRoles = userRolesRepository.GetAll().Where(r=>r.UserRoleId==entity.UserRoleId).FirstOrDefault();
            userRoles.UserRole=entity.UserRole;

            userRolesRepository.Update(userRoles);
        }

        public void DeleteUserRolesServices(UserRolesDTO entity)
        {      
            var userRoles = userRolesRepository.GetAll().Where(r=>r.UserRoleId==entity.UserRoleId).FirstOrDefault();
            userRoles.UserRole=entity.UserRole;

            userRolesRepository.Delete(userRoles);
         }

         public bool DeleteUserRolesServicesbyId(int id)
         {
             return userRolesRepository.DeletebyEntity(x=>x.UserRoleId==id);
         }
    }
}
