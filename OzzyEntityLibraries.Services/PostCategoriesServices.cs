using System.Linq;
using System.Collections.Generic;
using System;
using OzzyEntityLibraries.Repository;
using OzzyEntityLibraries.DTO.Models;
using OzzyEntityLibraries.ORM.Models;

namespace OzzyEntityLibraries.Services
{
    public class PostCategoriesServices
    {

       PostCategoriesRepository postCategoriesRepository;

       public PostCategoriesServices()
       {
           if (postCategoriesRepository==null)
           {
               postCategoriesRepository=new PostCategoriesRepository();
           }
       }

       public IEnumerable<PostCategoriesDTO> GetAllPostCategoriesService()
       {
            return postCategoriesRepository.GetAll().Select(r => new PostCategoriesDTO
            {
                PostCategoryId = r.PostCategoryId,
                PostCategoryName = r.PostCategoryName,
                PostCategoryPhoto = r.PostCategoryPhoto

            }).ToList();
       }

       public void AddPostCategoriesService(PostCategoriesDTO entity)
       {
           PostCategories postCategories = new PostCategories
           {
               PostCategoryName=entity.PostCategoryName,
               PostCategoryPhoto=entity.PostCategoryPhoto
           };
           postCategoriesRepository.Add(postCategories);   
       }

       public void UpdatePostCategoriesService(PostCategoriesDTO entity)
       {
           var postCategories = postCategoriesRepository.GetAll().Where(x=>x.PostCategoryId==entity.PostCategoryId).FirstOrDefault();
           postCategories.PostCategoryName=entity.PostCategoryName;
            postCategories.PostCategoryPhoto = entity.PostCategoryPhoto;

           postCategoriesRepository.Update(postCategories);
       }

       public void DeletePostCategoriesService(PostCategoriesDTO entity)
       {
           var postCategories = postCategoriesRepository.GetAll().Where(x=>x.PostCategoryId==entity.PostCategoryId).FirstOrDefault();
           postCategories.PostCategoryName=entity.PostCategoryName;
           postCategories.PostCategoryPhoto = entity.PostCategoryPhoto;

            postCategoriesRepository.Delete(postCategories);

       }
        
       public bool DeletePostCategoriesServiceByID(int id)
       {
           return postCategoriesRepository.DeletebyEntity(x=>x.PostCategoryId==id);
       }
    }
}
