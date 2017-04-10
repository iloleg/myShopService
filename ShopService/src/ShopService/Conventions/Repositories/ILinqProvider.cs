using System.Linq;


namespace ShopService.Conventions.Repositories
{
   public interface ILinqProvider
    {
        IQueryable<TEntity> Query<TEntity>()
            where TEntity : class, IEntity, new();
    }
}
