using System;
namespace CinePlus_BL.Dtos
{
    public class MovTheaterDto
    {
        public int ID { get; set; }
        public int QtyRows { get; set; }
        public int QtySeats { get; set; }
        public int cinemaID { get; set; }
        public DateTime createdAt { get; set; }
        public int createdByID { get; set; }
        public DateTime? modifiedAt { get; set; }
        public int? modifiedByID { get; set; }
    }

}

