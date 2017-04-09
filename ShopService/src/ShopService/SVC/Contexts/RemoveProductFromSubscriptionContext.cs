
using ShopService.Conventions.SVC.Commands;

namespace ShopService.SVC.Contexts
{
    public class RemoveProductFromSubscriptionContext : ICommandContext
    {
        public RemoveProductFromSubscriptionContext(long productId)
        {
            ProductId = productId;
        }

        public long ProductId { get; set; }
    }
}