using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Validata.Exam.Extentions;
using Validata.Exam.Repos;

namespace Validata.Exam
{
    public class Startup

    {

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }
         public void ConfigureServices(IServiceCollection services)
        {
            services.ConfigureCors();
            services.ConfigureRepositoryWrapper();
            services.ConfigureMsSqlConnection(Configuration);
            services.AddSingleton<OrderRepo>();
            services.AddControllers();
            services.AddMediatR(typeof(Startup));
        }


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseForwardedHeaders(new ForwardedHeadersOptions
            {
                ForwardedHeaders = Microsoft.AspNetCore.HttpOverrides.ForwardedHeaders.All
            });

            
            app.UseRouting();
            app.UseCors("CorsPolicy");
             
        }
    }
}
