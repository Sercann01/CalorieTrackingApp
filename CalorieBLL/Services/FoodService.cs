using CalorieDAL.Repositories;
using CalorieMODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieBLL.Services
{
    public class FoodService
    {
        FoodRepository foodRepository;
        public FoodService()
        {
            foodRepository = new FoodRepository();
        }

        public List<Food> ListAllFoods()
        {
            return foodRepository.ListAllFoods();
        }

        public List<Food> GetFoodsbyString(string text)
        {
            return foodRepository.GetFoodsbyString(text);
        }
        public Food GetFoodsbyID(int ID)
        {
            return foodRepository.GetFoodsbyID(ID);
        }






    }




    
}
