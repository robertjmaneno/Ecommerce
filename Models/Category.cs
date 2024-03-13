using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Models
{
    public class Category
    {

        [Key]
        public int CategoryId { get; set; }
        [Required(ErrorMessage ="The Category name is required")]      
        [DisplayName("Category Name")]
        public required string Name { get; set; }
        [DisplayName("Display Order")]
        [Range(1,100, ErrorMessage = "The display order must be at least 1 and not more than 100")]
        public int DisplayOrder { get; set; }
    }
}
