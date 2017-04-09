using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShopService.Conventions;
using ShopService.Conventions.SVC.Commands;
using ShopService.Conventions.Repositories;
using ShopService.SVC.Contexts;
using ShopService.Entities;

namespace ShopService.SVC.RepositoryCommands
{
    public class AddToSubscriptionRepositoryCommand : ICommand<AddToSubscriptionRepositoryContext>
    {
        private readonly IRepository<Product> _productRepository;

        public AddToSubscriptionRepositoryCommand(IRepository<Product> productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<CommandResult> ExecuteAsync(AddToSubscriptionRepositoryContext commandContext)
        {
            var product = await _productRepository.Query
                .Where(x => x.Id == commandContext.ProductId)
                .FirstOrDefaultAsync();

            product.SubscriptionId = commandContext.SubscriptionId;

            await _productRepository.SaveAsync();

            return CommandResult.Success;
        }
    }
}