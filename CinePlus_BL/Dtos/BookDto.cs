using System;
using CinePlus_DAL.Models;
using System.Xml.Linq;

namespace CinePlus_BL.Dtos
{
	public class BookDto
	{
            public int movScreeningBookID { get; set; }
            public int clientID { get; set; }
            public int qtySeats { get; set; }
            public List<Booking> booking { get; set; } //nose que hace
            public DateTime createdAt { get; set; }
            public int createdByID { get; set; }
            public DateTime? modifiedAt { get; set; }
            public int? modifiedByID { get; set; }
    }
}

