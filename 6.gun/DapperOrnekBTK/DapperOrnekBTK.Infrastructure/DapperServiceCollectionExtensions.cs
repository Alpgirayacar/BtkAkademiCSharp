using DapperOrnekBTK.Domain.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperOrnekBTK.Infrastructure
{
    public static class DapperServiceCollectionExtensions
    {
        public static IServiceCollection AddDapper(this IServiceCollection services)
        {
            services.AddTransient<ITodoItemRepository, TodoItemRepository>();

            return services;
        }
    }
}
