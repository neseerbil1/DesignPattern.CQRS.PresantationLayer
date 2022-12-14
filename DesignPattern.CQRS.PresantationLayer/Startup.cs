using DesignPattern.CQRS.PresantationLayer.CQRS.Handlers;
using DesignPattern.CQRS.PresantationLayer.CQRS.Handlers.PersonHandlers;
using DesignPattern.CQRS.PresantationLayer.CQRS.Handlers.UniversityHandlers;
using DesignPattern.CQRS.PresantationLayer.DAL.Concrete;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.CQRS.PresantationLayer
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
            services.AddDbContext<Context>();
            services.AddScoped<GetProductProducerQueryHandler>();
            services.AddScoped<GetProductPlannerQueryHandler>();
            services.AddScoped<GetPersonHumanResourceQueryHandler>();
            services.AddScoped<GetPersonByIdQueryHandler>();
            services.AddScoped<CreatePersonHandler>();

            services.AddScoped<GetAllUniversityQueryHandler>();
            services.AddScoped<GetUniversityByIDQueryHandler>();
            services.AddScoped<CreateUniversityHandler>();
            services.AddScoped<RemoveUniversityHandler>();
            services.AddScoped<GetUniversitytUpdateByIDQueryHandler>();
            services.AddScoped<UpdateUniversityHandler>();


            services.AddMediatR(typeof(Startup));

            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
