using System.Threading.Tasks;

namespace ShopService.Conventions.SVC.Commands
{
    public interface ICommand<in TCommandContext>
        where TCommandContext : ICommandContext
    {
      
       Task<CommandResult> ExecuteAsync(TCommandContext commandContext);
    }
}
