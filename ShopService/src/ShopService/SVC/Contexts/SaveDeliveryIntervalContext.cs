using System;
using System.Collections.Generic;

using ShopService.Conventions.SVC.Commands;
using ShopService.Entities;

namespace ShopService.SVC.Contexts
{
    public class SaveDeliveryIntervalContext : ICommandContext
    {
        public SaveDeliveryIntervalContext() { }

        public SaveDeliveryIntervalContext(DeliveryIntervalTemplate deliveryIntervalTemplate)
        {
            DeliveryIntervalTemplate = deliveryIntervalTemplate;
        }

        public DeliveryIntervalTemplate DeliveryIntervalTemplate { get; set; }
        public List<int> MonthDays { get; set; }
    }
}