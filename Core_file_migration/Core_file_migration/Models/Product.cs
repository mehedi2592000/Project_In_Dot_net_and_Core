using System.ComponentModel.DataAnnotations;

namespace Core_file_migration.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public String Name { get; set; }
        [Required]
        public int quantity { get; set; }
        [Required]
        public string ProductName { get; set; }


    }
}
