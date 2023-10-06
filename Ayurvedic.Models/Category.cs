using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Ayurvedic.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        [DisplayName("Category Name")] //client side validation
        public string Name { get; set; }
        [Range(1, 200, ErrorMessage = "Display Order must be between 1-100")]
        [DisplayName("Display Order")]
        public int DisplayOrder { get; set; }
    }
}
