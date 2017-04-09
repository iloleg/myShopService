using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopService.Conventions.SVC.Queries
{
    public class QueryFactory : IQueryFactory
    {
        private readonly IQueryResolver _queryResolver;

        public QueryFactory(IQueryResolver queryResolver)
        {
            _queryResolver = queryResolver;
        }

        public IQuery<TCriterion, TResult> Create<TCriterion, TResult>()
            where TCriterion : ICriterion
        {
            return _queryResolver.Resolve<TCriterion, TResult>();
        }
    }
}
