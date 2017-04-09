﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopService.Conventions.Repositories
{
    interface ILinqProvider
    {
        IQueryable<TEntity> Query<TEntity>()
            where TEntity : class, IEntity, new();
    }
}