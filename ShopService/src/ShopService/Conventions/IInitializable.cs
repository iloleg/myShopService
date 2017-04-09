using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopService.Conventions
{
    interface IInitializable
    {
        int Order { get; }
        void Initialize();
    }
}
