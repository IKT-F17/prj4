using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TDDB.Models
{
    public class Map
    {
        [Key]
        public string MapName { get; set; }

        [Required]
        public int MapScore { get; set; }

        public virtual User User { get; set; }
    }
}