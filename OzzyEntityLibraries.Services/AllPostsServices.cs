using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;
using System;
using OzzyEntityLibraries.Repository;
using OzzyEntityLibraries.DTO.Models;

namespace OzzyEntityLibraries.Services
{
    public class AllPostsServices
    {
        AllPostsRepository allPostsRepository;
       public AllPostsServices()
       {
           if (allPostsRepository==null)
           {
               allPostsRepository=new AllPostsRepository();
           }
       }
       
       public IEnumerable<AllPostDTO> GetAllPostsService()
       {
           return allPostsRepository.GetAll().Select(x=> new AllPostDTO
           {
                PostId=x.PostId,
                PostCategoryName=x.PostCategoryName,
                PostTitle=x.PostTitle,
                PostDiscription=x.PostDiscription,
                PostPhoto=x.PostPhoto

           }).ToList();
       }


        // There is no any Add, Update or Delete methods for View 

    }
}
