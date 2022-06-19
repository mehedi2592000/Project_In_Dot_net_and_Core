using System.ComponentModel.DataAnnotations;

namespace Core_Again_practice.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int amount { get; set; }


        [Required]
        public string imgname { get; set; }

    }
}
