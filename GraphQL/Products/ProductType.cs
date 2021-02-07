using System.Linq;
using ecommerce_gql_learning.Data;
using ecommerce_gql_learning.Models;
using HotChocolate;
using HotChocolate.Types;

namespace ecommerce_gql_learning.GraphQL.Products
{
    public class ProductType : ObjectType<Product>
    {
        protected override void Configure(IObjectTypeDescriptor<Product> descriptor)
        {
            descriptor.Description("These are products for the shop");
            descriptor
                .Field(p => p.Category)
                .ResolveWith<Resolvers>(p => p.GetProduct(default!, default!))
                .Description("This is the category that belongs to the product");

        }
        private class Resolvers
        {
            public Product GetProduct(Category category, [ScopedService] AppDbContext context)
            {
                return context.Products.FirstOrDefault(p => p.Id == category.Id);
            }
        }
    }
}