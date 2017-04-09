using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopService.Conventions.SVC.Commands
{
    interface ICommandFactory
    {
        ICommand<TCommandContext> Create<TCommandContext>()
            where TCommandContext : ICommandContext;
    }
}
