using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CinePlus_DAL.Models
{
    public class Person
    {
        [Key]
        public int ID { get; set; }
        public string role { get; set; }
        public string name { get; set; }
        public string lastName { get; set; }

        public DateTime createdAt { get; set; }

        public DateTime? modifiedAt { get; set; }

        [ForeignKey("ModifiedBy")]
        public int? ModifiedById { get; set; }
        public Person ModifiedBy { get; set; }

        public ICollection<MoviePerson> MoviePersons { get; set; }
    }
}
