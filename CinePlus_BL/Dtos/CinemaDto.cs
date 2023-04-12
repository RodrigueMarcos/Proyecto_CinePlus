using System;
namespace CinePlus_BL.Dtos
{
	public class CinemaDto
	{       
        public string name { get; set; }
        public string address { get; set; }
        public List<int> movTheaterIDs { get; set; }
        public List<int> employeeIDs { get; set; }
        public DateTime createdAt { get; set; }
        public int createdByID { get; set; }
        public DateTime? modifiedAt { get; set; }
        public int? modifiedByID { get; set; }
    }
}

