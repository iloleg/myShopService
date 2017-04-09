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
    public class LastSubscriptionDateForSubscriptionRepositoryQuery : IQuery<LastSubscriptionDateForSubscriptionRepositoryCriterion, SubscriptionDate>
    {
        private readonly ILinqProvider _linqProvider;

        public LastSubscriptionDateForSubscriptionRepositoryQuery(ILinqProvider linqProvider)
        {
            _linqProvider = linqProvider;
        }

        public Task<SubscriptionDate> AskAsync(LastSubscriptionDateForSubscriptionRepositoryCriterion criterion)
        {
            return _linqProvider.Query<SubscriptionDate>()
                .Where(x => x.SubscriptionId == criterion.SubscriptionId)
                .OrderByDescending(x => x.Date)
                .FirstOrDefaultAsync();
        }
    }
}