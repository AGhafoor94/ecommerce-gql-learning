using System.Threading.Tasks;
using ecommerce_gql_learning.Data;
using ecommerce_gql_learning.GraphQL.Categories;
using ecommerce_gql_learning.GraphQL.Products;
using ecommerce_gql_learning.Models;
using HotChocolate;

namespace ecommerce_gql_learning.GraphQL
{
    public class Mutation
    {
        public async Task<AddCategoryPayload> AddCategoryAsync(AddCategoryInput input, [ScopedService] AppDbContext context)
        {
            var category = new Category
            {
                Name = input.name
            };
            context.Add(category);
            await context.SaveChangesAsync();
            return new AddCategoryPayload(category);
        }
        public async Task<AddProductPayload> AppProductAsync(AddProductInput input, [ScopedService] AppDbContext context)
        {
            var product = new Product
            {
                Name = input.name,
                Price = input.price,
                CategoryId = input.categoryId
            };
            context.Add(product);
            await context.SaveChangesAsync();
            return new AddProductPayload(product);
        }
    }
}