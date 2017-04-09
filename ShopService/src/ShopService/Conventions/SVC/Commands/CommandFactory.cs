using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopService.Conventions.SVC.Commands
{
    public class CommandFactory
    : ICommandFactory
    {
        private readonly ICommandResolver _commandResolver;

        public CommandFactory(ICommandResolver commandResolver)
        {
            _commandResolver = commandResolver;
        }

        public ICommand<TCommandContext> Create<TCommandContext>()
            where TCommandContext : ICommandContext
        {
            return _commandResolver.Resolve<TCommandContext>();
        }
    }
}
