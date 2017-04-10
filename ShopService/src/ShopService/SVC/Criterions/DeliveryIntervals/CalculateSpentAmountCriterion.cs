using System;
using ShopService.Conventions.SVC.Queries;

namespace ShopService.SVC.Criterions.DeliveryIntervals
{
    public class CalculateSpentAmountCriterion : ICriterion
    {
        public CalculateSpentAmountCriterion(DateTime today, double sumOfProductsInSubscription)
        {
            Today = today;
            SumOfProductsInSubscription = sumOfProductsInSubscription;
        }

        public DateTime Today { get; set; }
        public double SumOfProductsInSubscription { get; set; }
    }
}
