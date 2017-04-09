using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopService.Conventions.SVC.Queries
{
    interface IQuery<in TCriterion, TResult>
        where TCriterion : ICriterion
    {
      
        Task<TResult> AskAsync(TCriterion criterion);
    }
    
}
