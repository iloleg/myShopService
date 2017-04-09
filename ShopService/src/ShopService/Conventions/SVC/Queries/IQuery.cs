using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopService.Conventions.SVC.Queries
{
    public interface IQuery<in TCriterion, TResult>
        where TCriterion : ICriterion
    {
      
        Task<TResult> AskAsync(TCriterion criterion);
    }
    
}
