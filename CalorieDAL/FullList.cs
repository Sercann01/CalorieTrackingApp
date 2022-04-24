using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieDAL
{
    public class FullList
    {
        public int FoodID { get; set; }
        public double FoodAmount { get; set; }
        public string FoodName { get; set; }
        public double FoodCalorie { get; set; }
        public double carbohyrate { get; set; }
        public double Protein { get; set; }
        public double Fat { get; set; }
        public string MealName { get; set; }
        public string CategoryName { get; set; }
        public DateTime Date  { get; set; }
        public string UserName  { get; set; }        

    }
}
