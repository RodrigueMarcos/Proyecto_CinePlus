using System;
using CinePlus_DAL.Models;

namespace CinePlus_BL.Dtos
{
    public class UsuarioDto
    {
        public int ID { get; set; }
        public Role role { get; set; }
        public string name { get; set; }
        public string lastName { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime? modifiedAt { get; set; }
        public int? modifiedByID { get; set; }
        public string userName { get; set; }
    }

}

