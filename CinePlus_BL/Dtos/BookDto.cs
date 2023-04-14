namespace CinePlus_BL.Dtos
{
    public class BookDTO
    {
        public int ID { get; set; }
        public int MovScreeningID { get; set; }
        public int ClientID { get; set; }
        public int QtySeats { get; set; }
        public int FirstSeat { get; set; }

        public int CreatedById { get; set; }
        public int? ModifiedById { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime? modifiedAt { get; set; }
    }
}

