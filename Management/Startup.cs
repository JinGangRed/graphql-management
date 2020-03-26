using Domain;
using GraphiQl;
using GraphQLDomain;
using GraphQLDomain.Models;
using Management.Extensions;
using Management.Middlewares;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Management
{
    public class Startup
    {
        public static readonly string GraphQLEndPoint = "/api/graphql";
        public static readonly string GraphiQLEndPoint = "/graphql";
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

       

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<KestrelServerOptions>(options =>
            {
                options.AllowSynchronousIO = true;
            });
            services.Configure<IISServerOptions>(options =>
            {
                options.AllowSynchronousIO = true;
            });

            services.ConfigureAuthentication(Configuration);
            services.ConfigDBContext(Configuration);

            services.ConfigureGraphQL();
            services.AddControllers(options =>
            {
                options.Filters
                    .Add<ValidateModelActionFilter>();
            });
            //// ÷ÿµ„
            services.Configure<ApiBehaviorOptions>(options =>
            {
                options.SuppressModelStateInvalidFilter = true;
            });
            services.ConfigureSwagger();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.ConfigureUseSwagger();
            app.UseGraphiQl(GraphiQLEndPoint);

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();
            app.UseMiddleware<GraphQLMiddleware>(new GraphQLSettings
            {
                BuildUserContext = ctx => new GraphQLUserContext
                {
                    User = ctx.User
                },
                Path = GraphQLEndPoint
            });
            
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            app.UseRequestMiddleware();
        }
    }
}
