using System.Linq;
using ecommerce_gql_learning.Data;
using ecommerce_gql_learning.Models;
using HotChocolate;
using HotChocolate.Types;

namespace ecommerce_gql_learning.GraphQL.Categories
{
    public class CategoryType : ObjectType<Category>
    {
        protected override void Configure(IObjectTypeDescriptor<Category> descriptor)
        {
            descriptor.Description("These are the categories for the store");
            descriptor
                .Field(c => c.Products)
                .ResolveWith<Resolvers>(c => c.GetCategories(default!, default!))
                .Description("Get all categories");
        }
        private class Resolvers
        {
            public IQueryable<Category> GetCategories(Category categories, [ScopedService] AppDbContext context)
            {
                return context.Categories.Where(c => c.Id == categories.Id);
            }
        }
    }
}