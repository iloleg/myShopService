using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopService.Conventions.SVC.Queries
{
    public class QueryBuilder : IQueryBuilder
    {
        private readonly IQueryForResolver _queryForResolver;
        public QueryBuilder(IQueryForResolver queryForResolver)
        {
            _queryForResolver = queryForResolver;
        }

        public IQueryFor<TResult> For<TResult>()
        {
            return _queryForResolver.Resolve<TResult>();
        }
    }
}
