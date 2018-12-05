using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace TDDB.Models
{
    public class User
    {

        public User(int id, string uname, string pword, int Thighscore)
        {
            this.UserID = id;
            this.Username = uname;
            this.Password = pword;
            this.TotalHighscore = Thighscore;
        }



        [Key]
        public int UserID { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public int TotalHighscore { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Score> Scores { get; set; }


    }
}