namespace CinePlus_BL.Dtos
{
    public class GenereDTO
    {
        public int ID { get; set; }
        public string Title { get; set; }

        public int CreatedById { get; set; }
        public int? ModifiedById { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime? modifiedAt { get; set; }
    }

}

