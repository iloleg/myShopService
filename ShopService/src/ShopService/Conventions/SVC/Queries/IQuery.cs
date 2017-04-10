using System.Threading.Tasks;

namespace ShopService.Conventions.SVC.Queries
{
    public interface IQuery<in TCriterion, TResult>
        where TCriterion : ICriterion
    {
      
        Task<TResult> AskAsync(TCriterion criterion);
    }
    
}
