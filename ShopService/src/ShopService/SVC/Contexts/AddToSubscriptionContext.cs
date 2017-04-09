using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShopService.Conventions.SVC.Commands;

namespace ShopService.SVC.Contexts
{
    public class AddToSubscriptionContext : ICommandContext
    {
        public AddToSubscriptionContext(long productId)
        {
            ProductId = productId;
        }

        public long ProductId { get; set; }
    }
}