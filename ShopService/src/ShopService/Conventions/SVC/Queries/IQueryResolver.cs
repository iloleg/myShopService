using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopService.Conventions.SVC.Queries
{
    public interface IQueryResolver
    {
        IQuery<TCriterion, TResult> Resolve<TCriterion, TResult>() where TCriterion : ICriterion;
    }
}
