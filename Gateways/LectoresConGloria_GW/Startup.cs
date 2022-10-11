using LectoresConGloria_FWK.Interfaces;
using LectoresConGloria_SVC.Data;
using LectoresConGloria_SVC.Servicios;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LectoresConGloria_GW
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddDbContext<LectoresConGloria_Context>(ServiceLifetime.Singleton);
            services.AddTransient<ISVC_Categoria, SVC_Categoria>();
            services.AddTransient<ISVC_Click, SVC_Click>();
            services.AddTransient<ISVC_Formato, SVC_Formato>();
            services.AddTransient<ISVC_FormatoLibro, SVC_FormatoLibro>();
            services.AddTransient<ISVC_Lector, SVC_Lector>();
            services.AddTransient<ISVC_TextoCategoria, SVC_TextoCategoria>();
            services.AddTransient<ISVC_Texto, SVC_Texto>();
            services.AddTransient<ISVC_TextoLibro, SVC_TextoLibro>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
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
