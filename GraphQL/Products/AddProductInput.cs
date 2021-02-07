using ecommerce_gql_learning.Models;

namespace ecommerce_gql_learning.GraphQL.Products
{
    public record AddProductInput(string name, double price, int categoryId);
}