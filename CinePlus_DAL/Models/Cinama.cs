using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CinePlus_DAL.Models
{
    public class Cinema
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

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

