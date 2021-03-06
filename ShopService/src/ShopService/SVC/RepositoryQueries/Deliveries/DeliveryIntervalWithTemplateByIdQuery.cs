﻿
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ShopService.Conventions.SVC.Queries;
using ShopService.Conventions.Repositories;
using ShopService.SVC.Criterions.DeliveryIntervals;
using ShopService.Entities;


namespace ShopService.SVC.RepositoryQueries.Deliveries
{
    public class DeliveryIntervalWithTemplateByIdQuery : IQuery<DeliveryIntervalWithTemplateByIdCriterion, DeliveryInterval>
    {
        private readonly ILinqProvider _linqProvider;

        public DeliveryIntervalWithTemplateByIdQuery(ILinqProvider linqProvider)
        {
            _linqProvider = linqProvider;
        }

        public Task<DeliveryInterval> AskAsync(DeliveryIntervalWithTemplateByIdCriterion criterion)
        {
            return _linqProvider.Query<DeliveryInterval>()
                .Include(x => x.DeliveryIntervalTemplate)
                .Where(x => x.Id == criterion.DeliveryIntervalId)
                .FirstOrDefaultAsync();
        }
    }
}