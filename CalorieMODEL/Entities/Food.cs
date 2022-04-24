using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieMODEL.Entities
{
    public class Food
    {
        public Food()
        {
            Operations = new HashSet<Operation>();
        }
        public int FoodID { get; set; }

        public string FoodName { get; set; }
        public double Calorie { get; set; }
        public double Carbohydrate { get; set; }
        public double Protein { get; set; }
        public double Fat { get; set; }
        public string Portion { get; set; }
        

        public virtual ICollection<Operation> Operations { get; set; }
    }
}
