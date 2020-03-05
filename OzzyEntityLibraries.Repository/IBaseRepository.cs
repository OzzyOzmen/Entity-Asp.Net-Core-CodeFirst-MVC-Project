using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OzzyEntityLibraries.ORM.Models;

namespace OzzyEntityLibraries.Repository
{
    public interface IBaseRepository<T> where T:class
    {
         IEnumerable<T> GetAll();
         IEnumerable<T> GetbyEntity(Func<T, bool> entity);
         void Add(T entity);
         void AddRange(T entity);
         int Update(T entity);
         void Delete(T entity);
         bool DeletebyEntity(Func<T, bool> entity);

    }
}