using System;
using ShopService.Conventions.SVC.Queries;

namespace ShopService.SVC.Criterions.Subscriptions
{
    public class SubscriptionViewModelCriterion : ICriterion
    {
        public SubscriptionViewModelCriterion(DateTime pointedTodayDate)
        {
            PointedTodayDate = pointedTodayDate;
        }

        public DateTime PointedTodayDate { get; set; }
    }
}