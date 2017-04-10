using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ShopService.Conventions.Repositories;
using ShopService.Conventions.SVC.Queries;
using ShopService.SVC.Criterions.Products;
using Microsoft.EntityFrameworkCore;
using ShopService.Entities;

namespace ShopService.SVC.RepositoryQueries.Products
{


    public class AllProductsQuery : IQuery<AllProductsCriterion, List<Product>>
    {
        private readonly ILinqProvider _linqProvider;

        public AllProductsQuery(ILinqProvider linqProvider)
        {
            _linqProvider = linqProvider;
        }

        public Task<List<Product>> AskAsync(AllProductsCriterion criterion)
        {
            return _linqProvider.Query<Product>()
                .ToListAsync();
        }
    }
}