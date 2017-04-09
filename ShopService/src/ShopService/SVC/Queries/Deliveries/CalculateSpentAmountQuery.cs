using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NCrontab.Advanced;
using NCrontab.Advanced.Enumerations;
using ShopService.Conventions.SVC.Queries;
using ShopService.Conventions.Enums;
using ShopService.SVC.Criterions.DeliveryIntervals;
using ShopService.SVC.Criterions.Subscriptions;
using ShopService.Entities;
using ShopService.Models.SubscriptionViewModels;

namespace ShopService.SVC.Queries.Deliveries
{
    public class CalculateSpentAmountQuery
    : IQuery<CalculateSpentAmountCriterion, double>
    {
        private readonly IQueryBuilder _queryBuilder;

        public CalculateSpentAmountQuery(IQueryBuilder queryBuilder)
        {
            _queryBuilder = queryBuilder;
        }

        public async Task<double> AskAsync(CalculateSpentAmountCriterion criterion)
        {
            double calculatedSpendedAmount = 0;

            var subscriptionDatesCriterion = new SubscriptionDatesForSubscriptionCriterion();
            var subscriptionDates = await _queryBuilder.For<List<SubscriptionDate>>().WithAsync(subscriptionDatesCriterion);
            subscriptionDates = subscriptionDates.OrderBy(x => x.Date).ToList();
            var firstSubscriptionDate = subscriptionDates.FirstOrDefault();

            if (firstSubscriptionDate == null) return calculatedSpendedAmount;
            if (firstSubscriptionDate.Date >= criterion.Today) return calculatedSpendedAmount;

            var subscriptionActiveIntervals = new List<SubscriptionActiveInterval>();

            SubscriptionActiveInterval activeInterval = null;
            foreach (var subscriptionDate in subscriptionDates)
            {
                if (subscriptionDate.Date >= criterion.Today) break;

                if (subscriptionDate.Type == SubscriptionDateType.Start)
                {
                    activeInterval = new SubscriptionActiveInterval(criterion.Today) { BeginAt = subscriptionDate.Date };
                    subscriptionActiveIntervals.Add(activeInterval);
                }
                else
                {
                    activeInterval.EndAt = subscriptionDate.Date;
                }
            }

            var deliveryIntervalForSubscriptionCriterion = new DeliveryIntervalWithTemplateForSubscriptionCriterion();
            var deliveryInterval = await _queryBuilder.For<DeliveryInterval>().WithAsync(deliveryIntervalForSubscriptionCriterion);

            foreach (var subscriptionActiveInterval in subscriptionActiveIntervals)
            {
                var cronInstance = CrontabSchedule.Parse(deliveryInterval.CronString, CronStringFormat.WithSeconds);
                var nextOccurrences = cronInstance.GetNextOccurrences(subscriptionActiveInterval.BeginAt, subscriptionActiveInterval.EndAt);
                calculatedSpendedAmount += nextOccurrences.Count() * criterion.SumOfProductsInSubscription;
            }

            return calculatedSpendedAmount;
        }
    }
}
