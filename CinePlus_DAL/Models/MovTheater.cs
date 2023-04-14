using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CinePlus_DAL.Models
{
    public class MovTheater
    {
        [Key]
        public int ID { get; set; }
        public int QtyRows { get; set; }
        public int QtySeats { get; set; }
        [ForeignKey("Cinema")]
        public int CinemaId { get; set; }
        public Cinema Cinema { get; set; }

        public DateTime createdAt { get; set; }

        [ForeignKey("CreatedBy")]
        public int CreatedById { get; set; }
        public Person CreatedBy { get; set; }

        public DateTime? modifiedAt { get; set; }

        [ForeignKey("ModifiedBy")]
        public int? ModifiedById { get; set; }
        public Person ModifiedBy { get; set; }
    }
}

