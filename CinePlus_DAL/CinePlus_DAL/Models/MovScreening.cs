using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;

namespace CinePlus_DAL.Models
{
	public class MovScreening
	{
        [Key]
        public int ID { get; set; }
        public DateTime date { get; set; }
        public Movie movie { get; set; }
        public MovTheater movTheater { get; set; }
        public MovType movType { get; set; }
        public DateTime createdAt { get; set; }
        public Person createdBy { get; set; }
        public DateTime? modifiedAt { get; set; }
        public Person? modifiedBy { get; set; }
    }
}

