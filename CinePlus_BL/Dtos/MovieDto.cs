using System;
using CinePlus_DAL.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace CinePlus_BL.Dtos
{
    public class MovieDTO
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public ICollection<GenereDTO> Genres { get; set; }
        public int Duration { get; set; }
        public int DirectorID { get; set; }
        public PersonDTO Director { get; set; }
        public string Synopsis { get; set; }

        public int CreatedById { get; set; }
        public int? ModifiedById { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime? modifiedAt { get; set; }
    }
}

