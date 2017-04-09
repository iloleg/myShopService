using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShopService.Conventions;

namespace ShopService.Entities
{
    public class Product : IEntity
    {
        public long Id { get; set; }

        public string Name { get; set; }
        public double Price { get; set; }

        public long? SubscriptionId { get; set; }

        public Subscription Subscription { get; set; }

        public bool InSubscription => SubscriptionId.HasValue;
    }
}