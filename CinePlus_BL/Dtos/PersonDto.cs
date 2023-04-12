using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinePlus_DAL.Models;

namespace CinePlus_BL.Dtos
{
    public class PersonDto
    {
        public Role role { get; set; }
        public string name { get; set; }
        public string lastName { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime? modifiedAt { get; set; }
        public int? modifiedByID { get; set; }
    }
}
