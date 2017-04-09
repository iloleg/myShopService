
using System.Threading.Tasks;

namespace ShopService.Conventions.SVC.Commands
{
    public interface ICommandRunner
    {
        Task RunAsync<TCommandContext>(TCommandContext commandContext)
            where TCommandContext : ICommandContext;
    }
}
