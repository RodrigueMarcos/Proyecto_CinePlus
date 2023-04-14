using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace CinePlus_DAL.Models
{
    public class Genere
    {
        [Key]
        public int ID { get; set; }
        public string Title { get; set; }

        public DateTime createdAt { get; set; }

        [ForeignKey("CreatedBy")]
        public int CreatedById { get; set; }
        public Person CreatedBy { get; set; }

        public DateTime? modifiedAt { get; set; }

        [ForeignKey("ModifiedBy")]
        public int? ModifiedById { get; set; }
        public Person ModifiedBy { get; set; }

        public ICollection<MovieGenere> MovieGeneres { get; set; }
    }


}

