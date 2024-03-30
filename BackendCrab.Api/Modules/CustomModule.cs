using Autofac;
using BackendCrab.BusinessLayer.Mapping;
using BackendCrab.BusinessLayer.Service;
using BackendCrab.Core.Repositories;
using BackendCrab.Core.Services;
using BackendCrab.Core.UnitOfWorks;
using BackendCrab.DataAccessLayer;
using BackendCrab.DataAccessLayer.Repositories;
using BackendCrab.DataAccessLayer.UnitOfWork;
using System.Reflection;
using Module = Autofac.Module;

namespace BackendCrab.Api.Modules
{
    public class CustomModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterGeneric(typeof(GenericRepository<>)).As(typeof(IGenericRepository<>)).InstancePerLifetimeScope();
            builder.RegisterGeneric(typeof(GenericService<,>)).As(typeof(IGenericService<,>)).InstancePerLifetimeScope();
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerLifetimeScope();

            var apiAssembly = Assembly.GetExecutingAssembly();
            var repositoryAssembly = Assembly.GetAssembly(typeof(AppDbContext));
            var serviceAssembly = Assembly.GetAssembly(typeof(MapProfile));

            builder.RegisterAssemblyTypes(apiAssembly, repositoryAssembly, serviceAssembly).Where(x => x.Name.EndsWith("Repository")).AsImplementedInterfaces().InstancePerLifetimeScope();
            builder.RegisterAssemblyTypes(apiAssembly, repositoryAssembly, serviceAssembly).Where(x => x.Name.EndsWith("Service")).AsImplementedInterfaces().InstancePerLifetimeScope();

            base.Load(builder);
        }
    }
}
