using System;
namespace CinePlus_BL.Dtos
{
    public class MovTheaterDTO
    {
        public int ID { get; set; }
        public int QtyRows { get; set; }
        public int QtySeats { get; set; }
        public int CinemaId { get; set; }

        public int CreatedById { get; set; }
        public int? ModifiedById { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime? modifiedAt { get; set; }
    }
}

