using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShopService.Conventions.SVC.Commands;
using ShopService.Entities;

namespace ShopService.SVC.Contexts
{
    public class SaveDeliveryIntervalRepositoryContext : ICommandContext
    {
        public SaveDeliveryIntervalRepositoryContext(DeliveryInterval deliveryInterval)
        {
            DeliveryInterval = deliveryInterval;
        }

        public DeliveryInterval DeliveryInterval { get; set; }
    }
}