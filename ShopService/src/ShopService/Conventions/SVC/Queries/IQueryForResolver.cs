using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopService.Conventions.SVC.Queries
{
    public interface IQueryForResolver
    {
        IQueryFor<T> Resolve<T>();
    }
}
