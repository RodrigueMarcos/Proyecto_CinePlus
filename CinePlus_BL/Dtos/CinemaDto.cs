namespace CinePlus_BL.Dtos
{
    public class CinemaDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public int CreatedById { get; set; }
        public int? ModifiedById { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime? modifiedAt { get; set; }
    }

}

