using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CinePlus_DAL.Models
{
    public class MovieGenere
    {
        [Key]
        public int ID { get; set; }

        [ForeignKey("Movie")]
        public int MovieID { get; set; }
        public Movie Movie { get; set; }

        [ForeignKey("Genere")]
        public int GenereID { get; set; }
        public Genere Genere { get; set; }
    }

}

