using System.ComponentModel.DataAnnotations;

namespace Core_Again_practice.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Imgname { get; set; }
        [Required]
        public int num { get; set; }
    }
}
