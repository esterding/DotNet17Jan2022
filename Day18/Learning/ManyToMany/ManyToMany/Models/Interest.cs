using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManyToMany.Models
{
    public class Interest
    {
        //public Interest()
        //{
        //    this.Users = new HashSet<User>();
        //}

        public int Id { get; set; }
        public string InterestName { get; set; }

        public ICollection<User> Users {get; set;}
    }
}
