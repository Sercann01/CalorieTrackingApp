using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieMODEL.Data_Transfer
{
    public class OperationData
    {
        public int OperationID { get; set; }
        public int FoodID { get; set; }
        public int MealID { get; set; }
        public int UserID { get; set; }
        public double FoodAmount { get; set; }
        public string FoodName { get; set; }
        public double Calorie { get; set; }
        public string Portion { get; set; }
        public double carbohyrate { get; set; }
        public double Protein { get; set; }
        public double Fat { get; set; }
        public string MealName { get; set; }
        public string CategoryName { get; set; }
        public DateTime Date { get; set; }
        public string UserName { get; set; }
    }
}
