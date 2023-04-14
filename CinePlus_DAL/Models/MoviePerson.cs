using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CinePlus_DAL.Models
{
    public class MoviePerson
    {
        [Key]
        public int ID { get; set; }
        [ForeignKey("Movie")]
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
        [ForeignKey("Person")]
        public int PersonId { get; set; }
        public Person Person { get; set; }
    }

}

