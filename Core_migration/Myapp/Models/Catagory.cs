namespace Myapp.Models
{
    public class Catagory
    {

        public int Id { get; set; }

        public string Name { get;set;}

        public int DisplayOrder { get; set; }

        public int Inte { get; set; }

        public DateTime CreatedDateTime { get; set; }=DateTime.Now;
    }
}
