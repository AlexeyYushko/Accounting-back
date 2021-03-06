using ASPNetDocker.DataAccess.Interfaces;
using ASPNetDocker.DataAccess.Repositories;
using ASPNetDocker.Extensions;
using ASPNetDocker.Interfaces;
using ASPNetDocker.Managers;
using ASPNetDocker.Middleware;
using ASPNetDocker.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ASPNetDocker
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        private readonly string myAllowedSpecificOrigins = "allowedSpecificOrigins";

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddTransient<IBaseRepository, BaseRepository>();
            services.AddTransient<ISqlScriptReader, SqlScriptReader>();
            services.AddTransient<IUsersManager, UsersManager>();
            services.AddTransient<IUsersRepository, UsersRepository>();
            services.AddTransient<IBillManager, BillManager>();
            services.AddTransient<IBillRepository, BillRepository>();
            services.AddTransient<ICurrencyManager, CurrencyManager>();
            services.AddTransient<ICurrencyRepository, CurrencyRepository>();
            services.AddTransient<ICategoryManager, CategoryManager>();
            services.AddTransient<ICategoryRepository, CategoryRepository>();
            services.AddTransient<IEventManager, EventManager>();
            services.AddTransient<IEventRepository, EventRepository>();

            services.AddCors(options =>
            {
                options.AddPolicy(name: myAllowedSpecificOrigins,
                    builder =>
                    {
                        builder.WithOrigins("http://localhost:5200");
                        builder.AllowAnyMethod();
                        builder.AllowAnyHeader();
                    });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            
            app.UseAuthorization();

            app.UseCors(myAllowedSpecificOrigins);
            app.UseMiddleware<ExceptionHandlingMiddleware>();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UsePing();
        }
    }
}
