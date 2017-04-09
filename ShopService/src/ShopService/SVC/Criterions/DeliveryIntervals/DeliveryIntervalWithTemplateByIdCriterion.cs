using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShopService.Conventions.SVC.Queries;


namespace ShopService.SVC.Criterions.DeliveryIntervals
{
    public class DeliveryIntervalWithTemplateByIdCriterion : ICriterion
    {
        public DeliveryIntervalWithTemplateByIdCriterion(long deliveryIntervalId)
        {
            DeliveryIntervalId = deliveryIntervalId;
        }

        public long DeliveryIntervalId { get; set; }
    }
}
