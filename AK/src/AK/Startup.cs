﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Hosting;
using Microsoft.AspNet.Http;
using Microsoft.Extensions.DependencyInjection;
using Ak.Services;
using Microsoft.Extensions.Configuration;
using Ak.Models;
using AutoMapper;
using Ak.ViewModels;

namespace AK
{
    public class Startup
    {
        public static IConfigurationRoot Configuration;

        public Startup(IHostingEnvironment appEnv)
        {
            var builder = new ConfigurationBuilder()
             //.SetBasePath(appEnv.WebRootPath)
             .AddJsonFile("config.json")
             .AddEnvironmentVariables();


            Configuration = builder.Build();
        }


        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            services.AddEntityFramework()
                .AddSqlServer()
                .AddDbContext<WorldContext>();


            services.AddTransient<WorldContextSeed>();

#if DEBUG
            services.AddScoped<ImailService, DebugMailService>();
#else
            //Here will be the real message service
            services.AddScoped<ImailService, DebugMailService>();
#endif
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, WorldContextSeed seeder)
        {
            //app.UseDefaultFiles();
            app.UseStaticFiles();


            Mapper.Initialize(config =>
            {
                config.CreateMap<EventViewModel, Event>().ReverseMap();
            });



            //var mp = new MapperConfiguration(cfg =>
            //{
            //    //cfg.AddProfile<AppProfile>();
            //    cfg.CreateMap<EventViewModel, Event>().ReverseMap();
            //});



            app.UseMvc(config=>
            {
                config.MapRoute(
                name: "Default",
                template: "{controller}/{action}/{id?}",
                defaults: new {controller="App",action="Index"}
                    );

            });
                       
            seeder.EnsureSeedData();
        }

        // Entry point for the application.
        public static void Main(string[] args) => WebApplication.Run<Startup>(args);
    }
}
