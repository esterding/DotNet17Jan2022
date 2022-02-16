using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ManyToMany.Models
{
    public class UserInterest
    {
        public int InterestId { get; set; }
        public int UserId { get; set; }
        //---------------------------------------------
        //relationships
        [ForeignKey("InterestId")]
        public Interest Interest { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }
       



    }
}
