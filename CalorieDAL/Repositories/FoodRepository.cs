using CalorieMODEL.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieDAL.Repositories
{
    public class FoodRepository
    {
        CalorieTrackingAppDbContext context;
        public FoodRepository()
        {
            context = new CalorieTrackingAppDbContext();

        }
        public List<Food> ListAllFoods()
        {

            // var result = context.Food.Join(context.Food, categorie => categorie.CategoryID, food => food.CategoryID, (categorie, food) =>
            //                   new
            //                   {
            //                       ID = food.FoodID,
            //                       foodName = food.FoodName,
            //                       calorie = food.Calorie,
            //                       carbohydrate = food.Carbohydrate,
            //                       protein = food.Protein,
            //                       fat = food.Fat,
            //                       portion = food.Portion,
            //                       amount = food.Amount,
            //                       categorieName = food.Category.CategoryName

            //                   }).ToList();

            List<Food> result = context.Food.ToList();
            return result;
        }

        public List<Food> GetFoodsbyString(string text)
        {
            List<Food> result = context.Food.Where(a => a.FoodName.Contains(text)).ToList();
            return result;
        }

        public Food GetFoodsbyID(int ID)
        {
            Food result = context.Food.Where(a => a.FoodID == ID).FirstOrDefault();
            return result;
        }
    }
}
