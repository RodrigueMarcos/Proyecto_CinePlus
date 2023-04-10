using System;
using CinePlus_DAL.Models;

namespace CinePlus_BL.Dtos
{
	public class MovScreeningDto
	{
        public int ID { get; set; }
        public MovTheater movTheaterID { get; set; }
        public Movie movID { get; set; }
        public DateTime startDateTime { get; set; }
        public DateTime createdAt { get; set; }
        public int createdByID { get; set; }
        public DateTime? modifiedAt { get; set; }
        public int? modifiedByID { get; set; }
    }
}

