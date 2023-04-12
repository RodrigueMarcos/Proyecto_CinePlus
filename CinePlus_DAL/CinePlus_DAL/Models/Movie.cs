using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;

namespace CinePlus_DAL.Models
{
	public class Movie
	{
        [Key]
        public int ID { get; set; }
        public string title { get; set; }
        public List<Genere> generes { get; set; }
        public int duration { get; set; }
        public Person director { get; set; }
        public List<Person> actors { get; set; }
        public string synopsis { get; set; }
        public DateTime createdAt { get; set; }
        public Person createdBy { get; set; }
        public DateTime? modifiedAt { get; set; }
        public Person? modifiedBy { get; set; }
    }
}

