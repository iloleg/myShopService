using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ShopService.Conventions;
using ShopService.Conventions.Repositories;

namespace ShopService.SVC.Repositories
{
    public sealed class LinqProvider : ILinqProvider
    {
        private readonly DbContext _context;

        public LinqProvider(DbContext context)
        {
            _context = context;
        }

        public IQueryable<TEntity> Query<TEntity>()
            where TEntity : class, IEntity, new()
        {
            var dbset = _context.Set<TEntity>();

            return dbset.AsNoTracking().AsQueryable();
        }
    }
}