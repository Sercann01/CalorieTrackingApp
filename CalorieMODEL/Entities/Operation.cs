using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieMODEL.Entities
{
    public class Operation
    {
        public int OperationID { get; set; }
        public double Amount { get; set; }
        public DateTime Date { get; set; }

        public int UserID { get; set; }
        public int FoodID { get; set; }
        public int MealID { get; set; }
        public virtual Meal Meal { get; set; }
        public virtual User User { get; set; }
        public virtual Food Food { get; set; }
    }
}
