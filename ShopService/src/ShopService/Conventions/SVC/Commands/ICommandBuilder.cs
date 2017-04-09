using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopService.Conventions.SVC.Commands
{
    interface ICommandBuilder
    {
        Task<CommandResult> ExecuteAsync<TCommandContext>(TCommandContext commandContext)
           where TCommandContext : ICommandContext;
    }
}
