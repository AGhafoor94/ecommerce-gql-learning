using System.ComponentModel.DataAnnotations;

namespace ecommerce_gql_learning.Models
{
    public class Categories
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}