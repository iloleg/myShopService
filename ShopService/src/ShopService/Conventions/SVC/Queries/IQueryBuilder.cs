using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopService.Conventions.SVC.Queries
{
    interface IQueryBuilder
    {
        IQueryFor<TResult> For<TResult>();
    }
}
