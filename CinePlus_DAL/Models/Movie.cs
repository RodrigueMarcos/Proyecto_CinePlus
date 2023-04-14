using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CinePlus_DAL.Models
{
    public class Movie
    {
        [Key]
        public int ID { get; set; }
        public string Title { get; set; }
        public int Duration { get; set; }
        [ForeignKey("Director")]
        public int DirectorID { get; set; }
        public Person Director { get; set; }
        public string Synopsis { get; set; }

        public DateTime createdAt { get; set; }

        [ForeignKey("CreatedBy")]
        public int CreatedById { get; set; }
        public Person CreatedBy { get; set; }

        public DateTime? modifiedAt { get; set; }

        [ForeignKey("ModifiedBy")]
        public int? ModifiedById { get; set; }
        public Person ModifiedBy { get; set; }

        public ICollection<MoviePerson> MoviePersons { get; set; }
        public ICollection<MovieGenere> MovieGeneres { get; set; }

    }
}
