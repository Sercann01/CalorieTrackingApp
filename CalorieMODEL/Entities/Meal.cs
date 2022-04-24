using CalorieMODEL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieMODEL.Entities
{
    public class Meal
    {
        public Meal()
        {
            Operations = new HashSet<Operation>();
        }
        public int MealID { get; set; }
        public string MealName { get; set; }
        public virtual ICollection<Operation> Operations { get; set; }
    }
}
