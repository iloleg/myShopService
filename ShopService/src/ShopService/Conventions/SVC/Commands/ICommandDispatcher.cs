
using System.Threading.Tasks;

namespace ShopService.Conventions.SVC.Commands
{
    public interface ICommandDispatcher
    {
        Task DispatchAsync<TCommandContext>(TCommandContext commandContext)
            where TCommandContext : ICommandContext;
    }
}
