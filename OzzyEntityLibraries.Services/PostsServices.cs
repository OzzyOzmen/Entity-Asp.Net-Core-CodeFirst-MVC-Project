using System.Linq;
using System.Collections.Generic;
using System;
using OzzyEntityLibraries.Repository;
using OzzyEntityLibraries.DTO.Models;
using OzzyEntityLibraries.ORM.Models;

namespace OzzyEntityLibraries.Services
{
    public class PostsServices
    {
       PostsRepository postsRepository;
      public PostsServices()
      {
          if (postsRepository==null)
          {
              postsRepository=new PostsRepository();
          }
      }
       
      public IEnumerable<PostsDTO> GetAllPostsService()
      {
           return postsRepository.GetAll().Select(x=> new PostsDTO
           {
               PostId=x.PostId,
               PostCategoryId=x.PostCategoryId,
               PostTitle=x.PostTitle,
               PostDiscription=x.PostDiscription,
               PostPhoto=x.PostPhoto

           }).ToList();
      }

      public void AddPostsService(PostsDTO entity)
      { 
           Posts posts = new Posts
           {
                PostCategoryId =entity.PostCategoryId,
                PostTitle = entity.PostTitle,
                PostDiscription=entity.PostDiscription,
                PostPhoto=entity.PostPhoto
           };  

           postsRepository .Add(posts); 
      }

      public void UpdatePostsService(PostsDTO entity)
      {
          var posts = postsRepository.GetAll().Where(x=>x.PostId==entity.PostId).FirstOrDefault();
          posts.PostCategoryId =entity.PostCategoryId;
          posts.PostTitle=entity.PostTitle;
          posts.PostDiscription=entity.PostDiscription;
          posts.PostPhoto=entity.PostPhoto;

          postsRepository.Update(posts);
      }
       
     public void DeletePostsService(PostsDTO entity)
     {
         var posts = postsRepository.GetAll().Where(x=>x.PostId==entity.PostId).FirstOrDefault();
          posts.PostCategoryId =entity.PostCategoryId;
          posts.PostTitle=entity.PostTitle;
          posts.PostDiscription=entity.PostDiscription;
          posts.PostPhoto=entity.PostPhoto;

          postsRepository.Delete(posts);
     }

     public bool DeletePostsServiceById(int id)
     {
         return postsRepository.DeletebyEntity(x=>x.PostId==id);
     }

    }
}
