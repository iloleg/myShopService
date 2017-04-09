using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ShopService.Conventions.SVC.Queries;
using ShopService.Conventions.Repositories;
using ShopService.SVC.Criterions.DeliveryIntervals;
using ShopService.Entities;

namespace ShopService.SVC.RepositoryQueries.Deliveries
{
    public class DeliveryIntervalTemplateByIdQuery : IQuery<DeliveryIntervalTemplateByIdCriterion, DeliveryIntervalTemplate>
    {
        private readonly ILinqProvider _linqProvider;

        public DeliveryIntervalTemplateByIdQuery(ILinqProvider linqProvider)
        {
            _linqProvider = linqProvider;
        }

        public Task<DeliveryIntervalTemplate> AskAsync(DeliveryIntervalTemplateByIdCriterion criterion)
        {
            return _linqProvider.Query<DeliveryIntervalTemplate>()
                    .FirstOrDefaultAsync(x => x.Id == criterion.DeliveryIntervalTemplateId);
        }
    }
}
    