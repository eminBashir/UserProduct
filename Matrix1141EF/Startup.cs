using Matrix1141EF.Data;
using Matrix1141EF.Data.Entity;
using Matrix1141EF.Repository.Impl;
using Matrix1141EF.Repository.Interface;
using Matrix1141EF.Service.Impl;
using Matrix1141EF.Service.Interface;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Matrix1141EF
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

            services.AddControllers();
            services.AddDbContext<AppDbContext>(op =>
            {
                op.UseSqlServer(Configuration.GetConnectionString("Default"));
            });

            services.AddIdentity<User,Role>(op =>
            {
                op.Password.RequireNonAlphanumeric = false;
                op.Password.RequiredLength = 6;
                op.Password.RequireUppercase = false;
                op.Password.RequireDigit = false;
                op.User.RequireUniqueEmail = true;
            })
                .AddDefaultTokenProviders()
                .AddEntityFrameworkStores<AppDbContext>();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Matrix1141EF", Version = "v1" });
            });
            services.AddMvc().AddNewtonsoftJson(options => { options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore; });  //Fix cycle problem
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddScoped<IProductService,ProductService>();
            services.AddScoped<IProductRepostory,ProductRepostory>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<ICategoryRepostory, CategoryRepostory>();


        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Matrix1141EF v1"));
            }
            app.UseHttpsRedirection();

            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
