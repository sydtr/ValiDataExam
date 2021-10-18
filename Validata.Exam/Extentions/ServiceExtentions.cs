using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Validata.Contract;
using Validata.Entities;
using Validata.Repository;

namespace Validata.Exam.Extentions
{
    public static class ServiceExtentions
    {

        public static void ConfigureCors(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
            });
        }
        public static void ConfigureRepositoryWrapper(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }

        public static void ConfigureMsSqlConnection(this IServiceCollection services,IConfiguration config)
        {
            var cnnStr = config["mssqlconnection:connectionString"];
            services.AddDbContext<RepositoryContext>(o => new SqlConnection(cnnStr));
        }
    }
}
