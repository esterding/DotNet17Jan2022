using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManyToMany.Models
{
    public class User
    {
        //public User()
        //{
        //    this.Interests = new HashSet<Interest>();
        //}

        public int Id { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }
        //public Interest Interest { get; set; }
        public ICollection<Interest> Interests { get; set; }

    }
}
