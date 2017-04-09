using System.Threading.Tasks;
using ShopService.Conventions;
using ShopService.Conventions.SVC.Commands;
using ShopService.Conventions.SVC.Queries;
using ShopService.SVC.Contexts;
using ShopService.SVC.Criterions.Subscriptions;

namespace ShopService.SVC.Commands
{
    public class AddToSubscriptionCommand
    : ICommand<AddToSubscriptionContext>
    {
        private readonly ICommandBuilder _commandBuilder;
        private readonly IQueryBuilder _queryBuilder;

        public AddToSubscriptionCommand(ICommandBuilder commandBuilder, IQueryBuilder queryBuilder)
        {
            _commandBuilder = commandBuilder;
            _queryBuilder = queryBuilder;
        }

        public async Task<CommandResult> ExecuteAsync(AddToSubscriptionContext commandContext)
        {
            var subscriptionIdCriterion = new SubscriptionIdCriterion();
            var subscriptionId = await _queryBuilder.For<long>().WithAsync(subscriptionIdCriterion);

            var repoContext = new AddToSubscriptionRepositoryContext(commandContext.ProductId, subscriptionId);

            return await _commandBuilder.ExecuteAsync(repoContext);
        }
    }
}
