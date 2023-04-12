using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;

namespace CinePlus_DAL.Models
{
	public class Person
	{
        [Key]
        public int ID { get; set; }
        public Role role { get; set; }
        public string name { get; set; }
        public string lastName { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime? modifiedAt { get; set; }
        public Person? modifiedBy { get; set; }

        public static implicit operator Person?(int? v)
        {
            throw new NotImplementedException();
        }
    }
}

