using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using ShopService.Conventions;

namespace ShopService.Entities
{
    public class ApplicationRole : IdentityRole<long>, IEntity
    {
    }
}