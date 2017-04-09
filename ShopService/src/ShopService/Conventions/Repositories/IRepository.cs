using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopService.Conventions.Repositories
{
    public interface IRepository<T> where T : class, IEntity
    {
        
        IQueryable<T> Query { get; }
       
        IQueryable<T> ReadQuery { get; }
        T Get(object id);
       
        T Add(T entity);
       
        void Delete(T entity);
       
        void Edit(T entity);
       
        void Edit(IList<T> entities);
     
        IList<T> AddRange(IList<T> entities);
      
        void DeleteRange(IList<T> entities);
      
        IEnumerable<T> GetAll();
    
        void Save();
      
        Task SaveAsync();
    }
}