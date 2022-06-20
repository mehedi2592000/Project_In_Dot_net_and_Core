using System.ComponentModel.DataAnnotations;

namespace Core_file_migration.Models.allmodel
{
    public class CustomerModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public IFormFile Imgname { get; set; }
        [Required]
        public int num { get; set; }
    }
}
