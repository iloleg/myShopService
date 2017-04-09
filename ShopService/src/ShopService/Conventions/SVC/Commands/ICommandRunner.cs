﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopService.Conventions.SVC.Commands
{
    interface ICommandRunner
    {
        Task RunAsync<TCommandContext>(TCommandContext commandContext)
            where TCommandContext : ICommandContext;
    }
}
