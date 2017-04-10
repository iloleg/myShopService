
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ShopService.Conventions.SVC.Queries;
using ShopService.Conventions.Repositories;
using ShopService.SVC.Criterions.DeliveryIntervals;
using ShopService.Entities;

namespace ShopService.SVC.RepositoryQueries.Deliveries
{
    public class AllDeliveryIntervalTemplatesQuery : IQuery<AllDeliveryIntervalTemplatesCriterion, List<DeliveryIntervalTemplate>>
    {
        private readonly ILinqProvider _linqProvider;

        public AllDeliveryIntervalTemplatesQuery(ILinqProvider linqProvider)
        {
            _linqProvider = linqProvider;
        }

        public Task<List<DeliveryIntervalTemplate>> AskAsync(AllDeliveryIntervalTemplatesCriterion criterion)
        {
            return _linqProvider.Query<DeliveryIntervalTemplate>().ToListAsync();
        }
    }
}