using ApplicationCommerciale.Core.Interfaces;
using ApplicationCommerciale.Core.Services;
using ApplicationCommerciale.Infrastructure.Data;
using ApplicationCommerciale.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCommerciale.Infrastructure
{
public static class InfrasturctureRegistration
    {

        public static IServiceCollection InfrastructureConfiguration(this IServiceCollection services, IConfiguration configuration)
        {








            //configure Token Services
            services.AddScoped<ITokenServices, TokenServices>();


            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

            services.AddScoped<IUnitOfWork, UnitOfWork>();


            //Configuration de La base de donnée


            services.AddDbContext<ApplicationDbContext>(opt =>
            {
                opt.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            });

            return services;
        }  


    }
}
