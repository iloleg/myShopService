using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ShopService.Conventions.SVR.Queries;
using ShopService.Conventions.Repositories;
using ShopService.SRV.Criterions.DeliveryIntervals;
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