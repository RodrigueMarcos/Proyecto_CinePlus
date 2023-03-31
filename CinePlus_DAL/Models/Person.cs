using System.ComponentModel.DataAnnotations;

namespace CinePlus_DAL.Models
{
    public class Person
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        
    }
}
