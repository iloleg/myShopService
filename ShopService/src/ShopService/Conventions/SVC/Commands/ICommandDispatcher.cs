using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopService.Conventions.SVC.Commands
{
    interface ICommandDispatcher
    {
        Task DispatchAsync<TCommandContext>(TCommandContext commandContext)
            where TCommandContext : ICommandContext;
    }
}
