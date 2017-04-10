
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ShopService.Conventions.SVC.Queries;
using ShopService.Conventions.Repositories;
using ShopService.SVC.Criterions.DeliveryIntervals;
using ShopService.Entities;

namespace ShopService.SVC.RepositoryQueries.Subscriptions
{
    
    public class SubscriptionDeliveryIntervalIdQuery : IQuery<SubscriptionDeliveryIntervalIdCriterion, long?>
    {
        private readonly ILinqProvider _linqProvider;

        public SubscriptionDeliveryIntervalIdQuery(ILinqProvider linqProvider)
        {
            _linqProvider = linqProvider;
        }

        public Task<long?> AskAsync(SubscriptionDeliveryIntervalIdCriterion criterion)
        {
            return _linqProvider.Query<Subscription>()
                .Select(x => x.DeliveryIntervalId)
                .FirstOrDefaultAsync();
        }
    }
}