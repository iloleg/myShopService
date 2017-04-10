using System.Threading.Tasks;

namespace ShopService.Conventions.SVC.Queries
{
    public interface IQueryFor<T>
    {
        Task<T> WithAsync<TCriterion>(TCriterion criterion)
           where TCriterion : ICriterion;
    }
}
