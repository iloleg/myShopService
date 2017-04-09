using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ShopService.Conventions.SVC.Queries;
using ShopService.Conventions.Repositories;
using ShopService.SVC.Criterions.Subscriptions;
using ShopService.Entities;

namespace ShopService.SVC.RepositoryQueries.Subscriptions
{
  

    public class SubscriptionWithProductsQuery : IQuery<SubscriptionWithProductsCriterion, Subscription>
    {
        private readonly ILinqProvider _linqProvider;

        public SubscriptionWithProductsQuery(ILinqProvider linqProvider)
        {
            _linqProvider = linqProvider;
        }

        public Task<Subscription> AskAsync(SubscriptionWithProductsCriterion criterion)
        {
            return _linqProvider.Query<Subscription>().Include(x => x.Products).FirstOrDefaultAsync();
        }
    }
}