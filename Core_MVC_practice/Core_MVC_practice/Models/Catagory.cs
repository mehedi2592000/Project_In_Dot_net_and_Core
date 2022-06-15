using System.ComponentModel.DataAnnotations;

namespace Core_MVC_practice.Models
{
    public class Catagory
    {
        [Key]
        public int Id  { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int DisplayOrder { get; set; }

        public DateTime CreatDatetime { get; set; } = DateTime.Now;
    }
}
