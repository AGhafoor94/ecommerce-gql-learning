using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ecommerce_gql_learning.Data;
using Microsoft.EntityFrameworkCore;
using ecommerce_gql_learning.GraphQL;
using ecommerce_gql_learning.GraphQL.Categories;
using ecommerce_gql_learning.GraphQL.Products;

namespace ecommerce_gql_learning
{
    public class Startup
    {
        private readonly IConfiguration _config;
        // Dependency Injecting config settings
        public Startup(IConfiguration config)
        {
            _config = config;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddPooledDbContextFactory<AppDbContext>(options =>
            {
                options.UseSqlServer(_config.GetConnectionString("DefaultConnection"));
            });
            services
                .AddGraphQLServer()
                .AddQueryType<Query>()
                .AddType<CategoryType>()
                .AddType<ProductType>()
                .AddFiltering()
                .AddSorting();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGraphQL();
            });
        }
    }
}
