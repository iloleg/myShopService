
using System.Threading.Tasks;
using ShopService.Conventions;
using ShopService.Conventions.SVC.Commands;
using ShopService.Conventions.Repositories;
using ShopService.SVC.Contexts;
using ShopService.Entities;


namespace ShopService.SVC.RepositoryCommands
{
    public class RemoveSubcriptionDateRepositoryCommand : ICommand<RemoveSubcriptionDateRepositoryContext>
    {
        private readonly IRepository<SubscriptionDate> _subscriptionDateRepository;

        public RemoveSubcriptionDateRepositoryCommand(IRepository<SubscriptionDate> subscriptionDateRepository)
        {
            _subscriptionDateRepository = subscriptionDateRepository;
        }

        public async Task<CommandResult> ExecuteAsync(RemoveSubcriptionDateRepositoryContext commandContext)
        {
            _subscriptionDateRepository.Delete(commandContext.SubscriptionDate);
            await _subscriptionDateRepository.SaveAsync();
            return CommandResult.Success;
        }
    }
}