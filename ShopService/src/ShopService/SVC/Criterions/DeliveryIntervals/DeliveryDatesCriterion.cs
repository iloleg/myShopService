using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShopService.Conventions.SVC.Queries;

namespace ShopService.SVC.Criterions.DeliveryIntervals
{
    public class DeliveryDatesCriterion : ICriterion
    {
        public DeliveryDatesCriterion(DateTime today, DateTime showUntil)
        {
            Today = today;
            ShowUntil = showUntil;
        }

        public DateTime Today { get; set; }
        public DateTime ShowUntil { get; set; }
    }
}
