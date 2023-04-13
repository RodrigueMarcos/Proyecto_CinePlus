using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;

namespace CinePlus_DAL.Models
{
	public class MovTheater
	{
        [Key]
        public int ID { get; set; }
        public int QtyRows { get; set; }
        public int QtySeats { get; set; }
        public Cinema Cinema { get; set; }
        public List<MovScreening>? movScreenings { get; set; }
        public DateTime createdAt { get; set; }
        public Person createdBy { get; set; }
        public DateTime? modifiedAt { get; set; }
        public Person? modifiedBy { get; set; }

    }   
}

