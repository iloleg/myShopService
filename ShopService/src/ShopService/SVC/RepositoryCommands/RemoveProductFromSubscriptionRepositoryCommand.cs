
using System.Linq;
using System.Threading.Tasks;
using ShopService.Conventions;
using ShopService.Conventions.SVC.Commands;
using ShopService.Conventions.Repositories;
using ShopService.SVC.Contexts;
using ShopService.Entities;
using Microsoft.EntityFrameworkCore;

namespace ShopService.SVC.RepositoryCommands
{
    

    public class RemoveProductFromSubscriptionRepositoryCommand : ICommand<RemoveProductFromSubscriptionRepositoryContext>
    {
        private readonly IRepository<Product> _productRepository;

        public RemoveProductFromSubscriptionRepositoryCommand(IRepository<Product> productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<CommandResult> ExecuteAsync(RemoveProductFromSubscriptionRepositoryContext commandContext)
        {
            var product = await _productRepository.Query
                .Where(x => x.Id == commandContext.ProductId)
                .FirstOrDefaultAsync();

            product.SubscriptionId = null;

            await _productRepository.SaveAsync();

            return CommandResult.Success;
        }
    }
}