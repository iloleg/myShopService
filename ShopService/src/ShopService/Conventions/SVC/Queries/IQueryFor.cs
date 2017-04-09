using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopService.Conventions.SVC.Queries
{
    interface IQueryFor<T>
    {
        Task<T> WithAsync<TCriterion>(TCriterion criterion)
           where TCriterion : ICriterion;
    }
}
