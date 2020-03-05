using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OzzyEntityLibraries.ORM.Models;

namespace OzzyEntityLibraries.Repository
{
    public class BaseRepository<T>:IBaseRepository<T> where T:class 
    {
        private OzzyEntityDataBaseContext context;
        public OzzyEntityDataBaseContext Context
        {
            get {
                
                if (context==null)
                {
                    context=new OzzyEntityDataBaseContext();
                } 
                 return context; 
                }
            set { context = value; }
        }
        
        public IEnumerable<T> GetAll()
        {
           return Context.Set<T>().ToList();
        }

        public IEnumerable<T> GetbyEntity(Func<T, bool> entity)
        {
           return Context.Set<T>().Where(entity);
        }

        public void Add(T entity)
        {
            Context.Set<T>().Add(entity);
            Context.SaveChanges();
        }

        public void AddRange(T entity)
        {
           Context.Set<T>().AddRange(entity);
           Context.SaveChanges();
        }

        public int Update(T entity)
        {
            return Context.SaveChanges();
        }

        public void Delete(T entity)
         {
             Context.Set<T>().Remove(entity);
             Context.SaveChanges();
        }
        public bool DeletebyEntity(Func<T, bool> entity)
         {
           var result = GetbyEntity(entity);
           if (result.Count()==0)
           return false;
           foreach (var item in result)
           {
               Context.Set<T>().Remove(item);
           }
           Context.SaveChanges();
           return true;
         }


    }
}
