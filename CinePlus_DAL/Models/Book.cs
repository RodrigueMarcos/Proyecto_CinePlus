using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;

namespace CinePlus_DAL.Models
{
	public class Book
	{
        [Key]
        public int ID { get; set; }
        public MovScreening movScreeningBook { get; set; }
        public Person client { get; set; }
        public int qtySeats { get; set; }
        public List<Booking> booking { get; set; } // para que es
        public DateTime createdAt { get; set; }
        public Person createdBy { get; set; }
        public DateTime? modifiedAt { get; set; }
        public Person? modifiedBy { get; set; }
    }
}

