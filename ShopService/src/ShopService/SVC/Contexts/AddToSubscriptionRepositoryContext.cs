using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShopService.Conventions.SVC.Commands;

namespace ShopService.SVC.Contexts
{
    public class AddToSubscriptionRepositoryContext : ICommandContext
    {
        public AddToSubscriptionRepositoryContext(long productId, long subscriptionId)
        {
            ProductId = productId;
            SubscriptionId = subscriptionId;
        }

        public long ProductId { get; set; }
        public long SubscriptionId { get; set; }
    }
}