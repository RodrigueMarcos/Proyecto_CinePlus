using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;

namespace CinePlus_DAL.Models
{
	public class Usuario : Person
	{
		public string userName { get; set; }
	}
}

