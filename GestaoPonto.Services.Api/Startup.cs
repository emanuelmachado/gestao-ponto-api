using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using GestaoPonto.Application.Interfaces;
using GestaoPonto.Application.Services;
using GestaoPonto.Domain.Interfaces;
using GestaoPonto.Repository.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace GestaoPonto.Services.Api
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
            services.AddScoped<IPointRegisterService, PointRegisterService>();
            services.AddScoped<ICollaboratorService, CollaboratorService>();
            services.AddScoped<IPointRegisterRepository, PointRegisterRepository>();
            services.AddScoped<ICollaboratorRepository, CollaboratorRepository>();
            var mapperConfig = Application.AutoMapper.AutoMapperConfiguration.RegisterMappings();

            IMapper mapper = mapperConfig.CreateMapper();

            services.AddSingleton(mapper);
            services.AddCors();
            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors( option => option.AllowAnyOrigin());

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
