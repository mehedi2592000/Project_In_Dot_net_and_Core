using System.ComponentModel.DataAnnotations;

namespace Core_Again_practice.Models.ModelData
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
