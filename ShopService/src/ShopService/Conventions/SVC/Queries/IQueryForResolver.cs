
namespace ShopService.Conventions.SVC.Queries
{
    public interface IQueryForResolver
    {
        IQueryFor<T> Resolve<T>();
    }
}
