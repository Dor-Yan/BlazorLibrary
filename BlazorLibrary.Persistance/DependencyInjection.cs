using BlazorLibrary.Application.Common.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorLibrary.Persistance
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersitance(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<BlazorLibraryDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("BlazorLibraryDataBase")));

            services.AddScoped<IBlazorLibraryDbContext, BlazorLibraryDbContext>();

            return services;
        }
    }
}
