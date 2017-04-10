using System;
using ShopService.Conventions.SVC.Commands;

namespace ShopService.SVC.Contexts
{
    public class SuspendResumeSubscriptionContext : ICommandContext
    {
        public SuspendResumeSubscriptionContext(DateTime today)
        {
            Today = today;
        }

        public DateTime Today { get; set; }
    }
}