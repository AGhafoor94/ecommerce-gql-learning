using System.Linq;
using ecommerce_gql_learning.Data;
using ecommerce_gql_learning.Models;
using HotChocolate;

namespace ecommerce_gql_learning.GraphQL
{
    public class Query
    {
        public IQueryable<Category> GetCategory([Service] AppDbContext context)
        {
            return context.Categories;
        }
        public IQueryable<Product> GetProduct([Service] AppDbContext context)
        {
            return context.Products;
        }
    }
}