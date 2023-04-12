using System;
namespace CinePlus_BL.Dtos
{
    public class MovieDto
    {
        public int ID { get; set; }
        public string title { get; set; }
        public List<int> genereIDs { get; set; }
        public int duration { get; set; }
        public int directorID { get; set; }
        public List<int> actorIDs { get; set; }
        public string synopsis { get; set; }
        public DateTime createdAt { get; set; }
        public int createdByID { get; set; }
        public DateTime? modifiedAt { get; set; }
        public int? modifiedByID { get; set; }
    }

}

