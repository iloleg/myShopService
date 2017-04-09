using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopService.Conventions.SVC.Queries
{
    public class QueryForTResult> : IQueryFor<TResult>
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

