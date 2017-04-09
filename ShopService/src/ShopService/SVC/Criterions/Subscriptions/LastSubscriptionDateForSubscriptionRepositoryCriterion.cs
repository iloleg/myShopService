using ShopService.Conventions.SVC.Queries;

namespace ShopService.SVC.Criterions.Subscriptions
{
    public class LastSubscriptionDateForSubscriptionRepositoryCriterion : ICriterion
    {
        public LastSubscriptionDateForSubscriptionRepositoryCriterion(long subscriptionId)
        {
            SubscriptionId = subscriptionId;
        }

        public long SubscriptionId { get; set; }
    }
}