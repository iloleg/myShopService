using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShopService.Conventions.SVC.Queries;

namespace ShopService.SVC.Criterions.Subscriptions
{
    public class SubscriptionDatesForSubscriptionRepositoryCriterion : ICriterion
    {
        public SubscriptionDatesForSubscriptionRepositoryCriterion(long subscriptionId)
        {
            SubscriptionId = subscriptionId;
        }

        public long SubscriptionId { get; set; }
    }
}