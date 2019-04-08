using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NetCore.AutoRegisterDi;
using Swashbuckle.AspNetCore.Swagger;
using System;
using System.Linq;
using System.Reflection;
using TestCore.Business.WorkFlowContextWork;
using TestCore.Business.WorkBusiness;
using TestCore.Repositories.UnitOfWork;

namespace TestCore.API
{
    /// <summary>
    /// 
    /// </summary>
    public class Startup
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="configuration"></param>
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        /// <summary>
        /// 
        /// </summary>
        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        /// <summary>
        /// 
        /// </summary>
        /// <param name="services"></param>
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAutoMapper();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1.0", new Info { Title = "Test Core API", Version = "1.0" });
                c.IncludeXmlComments(System.IO.Path.Combine(System.AppContext.BaseDirectory, "SwaggerDemo.xml"));
            });
            //var connection = Configuration.GetConnectionString("MyConnStr");
            //services.AddDbContext<WorkFlowContext>
            //    (options => options.UseLazyLoadingProxies().UseSqlServer(connection));
            services.AddSingleton(typeof(IUnitOfWork<>), typeof(WorkFlow<>));

            var assemblyToScan = Assembly.GetAssembly(typeof(EmployeeBusiness)); //..or whatever assembly you need
            services.RegisterAssemblyPublicNonGenericClasses(assemblyToScan)
              .Where(c => c.Name.EndsWith("Business"))
              .AsPublicImplementedInterfaces();
        }


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        /// <summary>
        /// 
        /// </summary>
        /// <param name="app"></param>
        /// <param name="env"></param>
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1.0/swagger.json", "Test Core API (V 1.0)");
            });
            app.UseMvc();
        }
    }
}
