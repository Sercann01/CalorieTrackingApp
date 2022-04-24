using CalorieMODEL.Data_Transfer;
using CalorieMODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CalorieDAL.Repositories
{

    public class OperationRepository
    {
        CalorieTrackingAppDbContext context;
        public OperationRepository()
        {
            context = new CalorieTrackingAppDbContext();

        }

        public bool Insert(Operation operation)
        {
            context.Operation.Add(operation);
            return context.SaveChanges() > 0;
        }
        //List<OperationData> list = new List<OperationData>();

        public bool Update(int amount, DateTime date, int userid, int mealid, int foodID)
        {
            bool check = false;
            Operation operation = context.Operation.Where(a => a.UserID == userid && a.FoodID == foodID && a.MealID == mealid && a.Date == date).SingleOrDefault();

            operation.Amount = amount;
            check = context.SaveChanges() == 1;
            return check;
        }

        public bool Delete(int userid, DateTime date, int mealid, int foodid)
        {
            bool check = false;
            Operation operation = context.Operation.Where(a => a.UserID == userid && a.Date == date && a.MealID == mealid && a.FoodID == foodid).SingleOrDefault();
            context.Operation.Remove(operation);
            check = context.SaveChanges() == 1;
            return check;
        }

        public List<OperationData> GetDataforMain(DateTime date, int userid, int mealid)
        {

            List<OperationData> result = (from operation in context.Operation
                                          join food in context.Food
                                          on operation.FoodID equals food.FoodID
                                          where operation.Date == date
                                          join meal in context.Meal
                                          on operation.MealID equals meal.MealID
                                          where meal.MealID == mealid
                                          join user in context.User
                                          on operation.UserID equals user.UserID
                                          where user.UserID == userid
                                          select new OperationData
                                          {
                                              FoodID = food.FoodID,
                                              FoodAmount = operation.Amount,
                                              FoodName = food.FoodName,
                                              Portion = food.Portion,
                                              Calorie = food.Calorie * operation.Amount,
                                              carbohyrate = food.Carbohydrate * operation.Amount,
                                              Fat = food.Fat * operation.Amount,
                                              Protein = food.Protein * operation.Amount,

                                          }).ToList();

            return result;

        }

        public List<OperationData> GetDataforPastRecords(DateTime date, int userid)
        {

            List<OperationData> result = (from operation in context.Operation
                                          join food in context.Food
                                          on operation.FoodID equals food.FoodID
                                          where operation.Date == date
                                          join meal in context.Meal
                                          on operation.MealID equals meal.MealID
                                          join user in context.User
                                          on operation.UserID equals user.UserID
                                          where user.UserID == userid
                                          select new OperationData
                                          {
                                              MealName = meal.MealName,
                                              FoodAmount = operation.Amount,
                                              FoodName = food.FoodName,
                                              Calorie = food.Calorie * operation.Amount,
                                              Date = operation.Date

                                          }).ToList();

            return result;
        }

        public List<OperationData> GetDailyResults(int userid, DateTime date)
        {
            List<OperationData> result = (from food in context.Food
                                          join operation in context.Operation
                                          on food.FoodID equals operation.FoodID
                                          where operation.Date == date && operation.UserID == userid
                                          select new OperationData
                                          {
                                              Calorie = food.Calorie * operation.Amount,
                                              Protein = food.Protein * operation.Amount,
                                              carbohyrate = food.Carbohydrate * operation.Amount,
                                              Fat = food.Fat * operation.Amount

                                          }).ToList();

            return result;

        }

        public List<OperationData> GetDailyResultsforMeal(int userid, DateTime date, int MealID)
        {
            List<OperationData> result = (from food in context.Food
                                          join operation in context.Operation
                                          on food.FoodID equals operation.FoodID
                                          where operation.Date == date && operation.UserID == userid && operation.MealID == MealID
                                          select new OperationData
                                          {
                                              Calorie = food.Calorie * operation.Amount,

                                          }).ToList();

            return result;

        }


        //public Dictionary<string, List<string>> GetCompareList(int mealid)
        //{
                                 
        //               var result = context.Operation.Join(context.Food,
        //                                                  op => op.FoodID,
        //                                                  fo => fo.FoodID,
        //                                                  (op, fo) => new { op, fo }).GroupBy(joinTable => new { joinTable.op.MealID , joinTable.fo.FoodID}).Select(a => new
        //                                                  {
        //                                                      FoodID = a.Key.FoodID,
        //                                                      MealID = a.Key.MealID,
        //                                                      Toplam = a.Sum(b => b.op.Amount)
        //                                                  }).OrderBy(b => b.Toplam).ToList(); 
            


        //}






    }

    class Sorgu 
    {

    }
}
