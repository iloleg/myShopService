
using System.Threading.Tasks;
using ShopService.Conventions;
using ShopService.Conventions.SVC.Commands;
using ShopService.Conventions.Repositories;
using ShopService.SVC.Contexts;
using ShopService.Entities;

namespace ShopService.SVC.RepositoryCommands
{
    public class AddSubcriptionDateRepositoryCommand : ICommand<AddSubcriptionDateRepositoryContext>
    {
        private readonly IRepository<SubscriptionDate> _subscriptionDateRepository;

        public AddSubcriptionDateRepositoryCommand(IRepository<SubscriptionDate> subscriptionDateRepository)
        {
            _subscriptionDateRepository = subscriptionDateRepository;
        }

        public async Task<CommandResult> ExecuteAsync(AddSubcriptionDateRepositoryContext commandContext)
        {
            _subscriptionDateRepository.Add(commandContext.SubscriptionDate);
            await _subscriptionDateRepository.SaveAsync();
            return CommandResult.Success;
        }
    }
}