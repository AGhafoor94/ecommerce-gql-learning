using System.Linq;
using ecommerce_gql_learning.Data;
using ecommerce_gql_learning.Models;
using HotChocolate;
using HotChocolate.Data;

namespace ecommerce_gql_learning.GraphQL
{
    public class Query
    {
        [UseDbContext(typeof(AppDbContext))]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Category> GetCategory([ScopedService] AppDbContext context)
        {
            return context.Categories;
        }
        [UseDbContext(typeof(AppDbContext))]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Product> GetProduct([ScopedService] AppDbContext context)
        {
            return context.Products;
        }
    }
}