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
    public class SubscriptionDatesForSubscriptionRepositoryQuery
        : IQuery<SubscriptionDatesForSubscriptionRepositoryCriterion, List<SubscriptionDate>>
    {
        private readonly ILinqProvider _linqProvider;

        public SubscriptionDatesForSubscriptionRepositoryQuery(ILinqProvider linqProvider)
        {
            _linqProvider = linqProvider;
        }

        public Task<List<SubscriptionDate>> AskAsync(SubscriptionDatesForSubscriptionRepositoryCriterion criterion)
        {
            return _linqProvider.Query<SubscriptionDate>()
                .Where(x => x.SubscriptionId == criterion.SubscriptionId)
                .ToListAsync();
        }
    }
}