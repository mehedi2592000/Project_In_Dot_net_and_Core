using System.ComponentModel.DataAnnotations;

namespace Core_file_migration.Models.allmodel
{
    public class ProductModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public String Name { get; set; }
        [Required]
        public int quantity { get; set; }
        [Required]
        public List<IFormFile> ProductName { get; set; }

    }
}
