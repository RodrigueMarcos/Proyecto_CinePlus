using System;
namespace CinePlus_BL.Dtos
{
    public class GenereDto
    {
        public int ID { get; set; }
        public string title { get; set; }
        public DateTime createdAt { get; set; }
        public int createdByID { get; set; }
        public DateTime? modifiedAt { get; set; }
        public int? modifiedByID { get; set; }
    }

}

