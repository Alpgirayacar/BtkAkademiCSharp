using Autofac;
using DapperOrnekBTK.Application;
using DapperOrnekBTK.Domain.Repository;
using DapperOrnekBTK.Infrastructure;

namespace DapperOrnekBTK.Web
{
    public class DapperTodoDemoApplicationModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<TodoItemRepository>().As<ITodoItemRepository>(); //TODO: it must not depend on infrastructure layer?
            builder.RegisterType<TodoItemAppService>().As<ITodoItemAppService>();
        }
    }
}
