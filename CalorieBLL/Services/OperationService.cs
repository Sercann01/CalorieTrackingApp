using CalorieDAL;
using CalorieDAL.Repositories;
using CalorieMODEL.Data_Transfer;
using CalorieMODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieBLL.Services
{
    public class OperationService
    {
        public OperationService()
        {
            operationRepository = new OperationRepository();
        }
        OperationRepository operationRepository;

        public bool Insert(Operation operation)
        {
            return operationRepository.Insert(operation);
        }
        //public List<Operation> GetOperation(DateTime time, int mealID)
        //{

        //    return operationRepository.GetOperation(time, mealID);
        //}

        //public List<FullList> GetSelectedFoods(DateTime time, int userid)
        //{
        //    return operationRepository.GetSelectedFoods(time,userid);
        //}

        public List<OperationData> GetDataforMain(DateTime date, int userid, int mealid)
        {
            return operationRepository.GetDataforMain(date, userid, mealid);
        }
        public List<OperationData> GetDataforPastRecords(DateTime date, int userid)
        {
            return operationRepository.GetDataforPastRecords(date, userid);
        }

        public List<OperationData> GetDailyResults(int userid, DateTime date)
        {
            return operationRepository.GetDailyResults(userid, date);
        }

        public List<OperationData> GetDailyResultsforMeal(int userid, DateTime date, int MealID)
        {
            return operationRepository.GetDailyResultsforMeal(userid, date, MealID);
        }

        public bool Update(int amount, DateTime date, int userid, int mealid, int foodID)
        {
            return operationRepository.Update(amount, date, userid, mealid, foodID);
        }

        public bool Delete(int userid, DateTime date, int mealid, int foodid)
        {
            return operationRepository.Delete(userid, date, mealid, foodid);
        }
    }
    




}
