using CalorieMODEL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieMODEL.Entities
{
    public class User
    {
        public User()
        {
            Operations = new HashSet<Operation>();
        }

        public int UserID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Gender { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public int Age { get; set; }
        public string SportBackground { get; set; }
        public string Usermail { get; set; }
        public string Password { get; set; }

        public virtual ICollection<Operation> Operations { get; set; }
    }
}
