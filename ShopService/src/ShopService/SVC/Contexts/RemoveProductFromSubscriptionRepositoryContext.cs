
using ShopService.Conventions.SVC.Commands;

namespace ShopService.SVC.Contexts
{
    public class RemoveProductFromSubscriptionRepositoryContext : ICommandContext
    {
        public RemoveProductFromSubscriptionRepositoryContext(long productId)
        {
            ProductId = productId;
        }

        public long ProductId { get; set; }
    }
}