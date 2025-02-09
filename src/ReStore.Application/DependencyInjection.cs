using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace ReStore.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services){

            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddMediatR(options=>{
                options.RegisterServicesFromAssemblyContaining(typeof(DependencyInjection));
            });
           
        
            return services;
        }
    }
}