using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ShopService.Conventions.SVC.Queries;
using ShopService.Conventions.Repositories;
using ShopService.SVC.Criterions.Subscriptions;
using ShopService.Entities;

namespace ShopService.SVC.RepositoryQueries.Subscriptions
{
    public class SubscriptionIdQuery : IQuery<SubscriptionIdCriterion, long>
    {
        private readonly ILinqProvider _linqProvider;

        public SubscriptionIdQuery(ILinqProvider linqProvider)
        {
            _linqProvider = linqProvider;
        }

        public Task<long> AskAsync(SubscriptionIdCriterion criterion)
        {
            return _linqProvider.Query<Subscription>().Select(x => x.Id).FirstOrDefaultAsync();
        }
    }
}