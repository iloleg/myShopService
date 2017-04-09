using System.Linq;
using System.Reflection;
using Autofac;
using Microsoft.EntityFrameworkCore;
using ShopService.Conventions;
using ShopService.Conventions.SVC.Commands;
using ShopService.Conventions.SVC.Queries;
using ShopService.Conventions.Repositories;
using ShopService.SVC.Repositories;
using ShopService.Data;
using ShopService.Initializers.AutofacConfigs.Resolver;

namespace ShopService.Initializers.AutofacConfigs
{
    
    public static class AutofacConfig
    {
        public static void RegisterDependencies(this ContainerBuilder builder)
        {
            var assemblies = new Assembly[]
            {
                typeof(ApplicationDbContext).GetTypeInfo().Assembly,
            };

            builder.RegisterAssemblyTypes(assemblies)
                .Where(t => t.GetInterfaces().Any(i => i.IsAssignableFrom(typeof(IInitializable))))
                .AsImplementedInterfaces();

            
            builder.RegisterAssemblyTypes(assemblies).AsClosedTypesOf(typeof(IQuery<,>));
            builder.RegisterGeneric(typeof(QueryFor<>)).As(typeof(IQueryFor<>));
            builder.RegisterType<QueryFactory>().As<IQueryFactory>();
            builder.RegisterType<QueryBuilder>().As<IQueryBuilder>();
            builder.RegisterType<QueryForResolver>().As<IQueryForResolver>();
            builder.RegisterType<QueryResolver>().As<IQueryResolver>();

            
            builder.RegisterAssemblyTypes(assemblies).AsClosedTypesOf(typeof(ICommand<>));
            builder.RegisterType<CommandResolver>().As<ICommandResolver>();
            builder.RegisterType<CommandFactory>().As<ICommandFactory>();
            builder.RegisterType<CommandBuilder>().As<ICommandBuilder>();

            
            builder.RegisterType<LinqProvider>().As<ILinqProvider>();
            builder.RegisterType<ApplicationDbContext>().As<DbContext>();
            builder.RegisterGeneric(typeof(EfRepository<>)).As(typeof(IRepository<>));
        }
    }
}