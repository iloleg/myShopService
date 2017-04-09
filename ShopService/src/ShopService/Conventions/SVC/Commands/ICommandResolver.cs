using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopService.Conventions.SVC.Commands
{
    interface ICommandResolver
    {
        ICommand<TCommandContext> Resolve<TCommandContext>()
           where TCommandContext : ICommandContext;
    }
}
