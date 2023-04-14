using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CinePlus_DAL.Models
{
    public class Book
    {
        [Key]
        public int ID { get; set; }

        [ForeignKey("movScreening")]
        public int MovScreeningID { get; set; }

        [ForeignKey("client")]
        public int ClientID { get; set; }
        public int qtySeats { get; set; }
        public int firstSeat { get; set; }

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

