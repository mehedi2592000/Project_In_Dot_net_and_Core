namespace Core_migration.Models
{
    public class Catagory
    {

        public int Id { get; set; }

        public string Name { get;set;}

        public int DisplayOrder { get; set; }

        public DateTime CreatedDateTime { get; set; }=DateTime.Now;
    }
}
