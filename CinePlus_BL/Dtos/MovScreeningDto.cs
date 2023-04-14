using System;
using CinePlus_DAL.Models;

namespace CinePlus_BL.Dtos
{
    public class MovScreeningDTO
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public int MovieId { get; set; }
        public int MovTheaterId { get; set; }
        public MovType MovType { get; set; }

        public int CreatedById { get; set; }
        public int? ModifiedById { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime? modifiedAt { get; set; }
    }

}

