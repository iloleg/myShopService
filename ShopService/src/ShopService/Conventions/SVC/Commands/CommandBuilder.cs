using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopService.Conventions.SVC.Commands
{
    public class CommandBuilder: ICommandBuilder
    {
        private readonly ICommandFactory _commandFactory;

        public CommandBuilder(ICommandFactory commandFactory)
        {
            _commandFactory = commandFactory;
        }

        public async Task<CommandResult> ExecuteAsync<TCommandContext>(TCommandContext commandContext)
            where TCommandContext : ICommandContext
        {
            return await _commandFactory.Create<TCommandContext>().ExecuteAsync(commandContext);
        }
    }
}
