﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Models
{
    public class Category
    {

        [Key]
        public int CategoryId { get; set; }

        [Required]
        [DisplayName("Category Name")]
        public required string Name { get; set; }
        [DisplayName("Display Order")]
        public int DisplayOrder { get; set; }
    }
}
