using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APICatalogo.Business.Interfaces;
using APICatalogo.Data.Context;
using APICatalogo.Data.Repositories;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace APICatalogo.Api
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
            services.AddDbContext<MyContext>(x=>x.UseSqlServer(Configuration.GetConnectionString("conecta")));
            services.AddAutoMapper(typeof(Startup));
            services.AddScoped<MyContext>();
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<ICategoriaRepository, CategoriaRepository>();
          
            services.AddControllers();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
