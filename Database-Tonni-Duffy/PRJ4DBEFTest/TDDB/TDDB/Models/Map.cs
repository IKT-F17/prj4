using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TDDB.Models
{
    public class Map
    {
        public Map(string mapname, int mapscore)
        {
            this.MapName = mapname;
            this.MapScore = mapscore;
        }
    
        [Key]
        public string MapName { get; set; }

        [Required]
        public int MapScore { get; set; }

        public virtual User User { get; set; }
    }
}