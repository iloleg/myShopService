using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopService.Conventions
{
    public CommandResult(bool isDone, string message = "", object addition = null)
    {
        IsDone = isDone;
        Message = !isDone && string.IsNullOrWhiteSpace(message) ? "Errors" : message;
        Addition = addition;
    }

   
    public bool IsDone { get; set; }
    
    public string Message { get; set; }

  
    public object Addition { get; set; }

    public static CommandResult Success = new CommandResult(true);
    public static CommandResult Failure = new CommandResult(false);
}

