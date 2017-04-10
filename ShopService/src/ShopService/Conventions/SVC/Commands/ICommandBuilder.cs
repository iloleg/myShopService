using System.Threading.Tasks;

namespace ShopService.Conventions.SVC.Commands
{
   public interface ICommandBuilder
    {
        Task<CommandResult> ExecuteAsync<TCommandContext>(TCommandContext commandContext)
           where TCommandContext : ICommandContext;
    }
}
