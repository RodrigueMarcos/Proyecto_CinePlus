using System.ComponentModel.DataAnnotations;

namespace Prueba_WebApplication2.Models
{
    public class Person
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        
    }
}
