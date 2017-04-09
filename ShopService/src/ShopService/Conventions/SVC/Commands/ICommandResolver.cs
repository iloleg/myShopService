

namespace ShopService.Conventions.SVC.Commands
{
    public interface ICommandResolver
    {
        ICommand<TCommandContext> Resolve<TCommandContext>()
           where TCommandContext : ICommandContext;
    }
}
