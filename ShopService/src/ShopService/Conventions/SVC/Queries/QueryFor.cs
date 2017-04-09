
using System.Threading.Tasks;

namespace ShopService.Conventions.SVC.Queries

{

    public class QueryFor<TResult> : IQueryFor<TResult>
    {
        private readonly IQueryFactory _factory;

      
        public QueryFor(IQueryFactory factory)
        {
            _factory = factory;
        }

        public async Task<TResult> WithAsync<TCriterion>(TCriterion criterion)
            where TCriterion : ICriterion
        {
            return await _factory.Create<TCriterion, TResult>().AskAsync(criterion);
        }
    }
}