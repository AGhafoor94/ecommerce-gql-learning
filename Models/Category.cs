using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace ecommerce_gql_learning.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        // Collection of products for a category
        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}