using ShopService.Conventions.SVC.Commands;
using ShopService.Entities;

namespace ShopService.SVC.Contexts
{
    public class AddSubcriptionDateRepositoryContext : ICommandContext
    {
        public AddSubcriptionDateRepositoryContext(SubscriptionDate subscriptionDate)
        {
            SubscriptionDate = subscriptionDate;
        }

        public SubscriptionDate SubscriptionDate { get; set; }
    }
}
