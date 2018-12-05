using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TDDB.Models
{
    public class Score
    {
        public Score(int ScoreID)
        {
            this.ScoreID = ScoreID;
        }


        [Key]
        public int ScoreID { get; set; }

        [Required]

        public virtual User User { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Map> Maps { get; set; }
    }
}