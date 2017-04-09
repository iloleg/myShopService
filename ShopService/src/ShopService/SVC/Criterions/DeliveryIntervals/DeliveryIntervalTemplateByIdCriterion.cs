﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShopService.Conventions.SVC.Queries;

namespace ShopService.SVC.Criterions.DeliveryIntervals
{
    public class DeliveryIntervalTemplateByIdCriterion : ICriterion

    {

        public DeliveryIntervalTemplateByIdCriterion(long deliveryIntervalTemplateId)
        {
            DeliveryIntervalTemplateId = deliveryIntervalTemplateId;
        }

        public long DeliveryIntervalTemplateId { get; set; }
    }
}