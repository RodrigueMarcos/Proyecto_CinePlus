using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CinePlus_DAL.Models
{
	public class Cinema
	{
		[Key]
		public int ID { get; set; }
		public string name { get; set; }
		public string address { get; set; }
		public List<MovTheater>? MovTheaters { get; set; }
		public List<Person>? employees { get; set; }
		public DateTime createdAt { get; set; }
		public Person createdBy { get; set; }
		public DateTime? modifiedAt { get; set; }
		public Person? modifiedBy { get; set; }
	}
}

