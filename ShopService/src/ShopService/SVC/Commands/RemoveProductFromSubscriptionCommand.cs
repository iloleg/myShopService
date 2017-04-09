using System;
using System.Threading.Tasks;
using ShopService.Conventions;
using ShopService.Conventions.SVC.Commands;
using ShopService.SVC.Contexts;

namespace ShopService.SVC.Commands
{
    public class RemoveProductFromSubscriptionCommand
    : ICommand<RemoveProductFromSubscriptionContext>
    {
        private readonly ICommandBuilder _commandBuilder;

        public RemoveProductFromSubscriptionCommand(ICommandBuilder commandBuilder)
        {
            _commandBuilder = commandBuilder;
        }

        public Task<CommandResult> ExecuteAsync(RemoveProductFromSubscriptionContext commandContext)
        {
            var repoContext = new RemoveProductFromSubscriptionRepositoryContext(commandContext.ProductId);
            return _commandBuilder.ExecuteAsync(repoContext);
        }
    }
}
