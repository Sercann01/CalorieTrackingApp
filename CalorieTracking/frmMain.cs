using CalorieBLL.Services;
using CalorieMODEL.Data_Transfer;
using CalorieMODEL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalorieTracking
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            foodService = new FoodService();
            userService = new UserService();
            operationService = new OperationService();
        }

        public frmMain(User user1)
        {
            InitializeComponent();
            user = user1;
            foodService = new FoodService();
            userService = new UserService();
            operationService = new OperationService();

        }       
        FoodService foodService;
        UserService userService;
        OperationService operationService;
        User user = new User();
        int mealİD;
        DateTime date;
        
        
        private void frmMain_Load(object sender, EventArgs e)
        {
           lblName.Text =  user.Name;
           date = DateTime.Today;

            List<OperationData> DailyFoodList =  operationService.GetDailyResults(user.UserID, date);

            double calorie = 0;
            double carbonhydrate = 0;
            double Protein = 0;
            double Fat = 0;

            foreach (var item in DailyFoodList)
            {
                calorie += item.Calorie;
                Protein += item.Protein;
                carbonhydrate += item.carbohyrate;
                Fat += item.Fat;
            }

            lblCalorie.Text = $"{calorie.ToString()} kcal";
            lblProtein.Text = $"{Protein.ToString()} gr";
            lblCarbonhydrate.Text = $"{carbonhydrate.ToString()} gr";
            lblFat.Text = $"{Fat.ToString()} gr";

            GetMealCalorie(lblBreakfastSum, 1, BreakfastCalorie);
            GetMealCalorie(lblLunchSum, 2, LunchCalorie);
            GetMealCalorie(lblDinnerSum, 3, DinnerCalorie);
            GetMealCalorie(lblSnackSum, 4, SnackCalorie);
            
        }


            double BreakfastCalorie = 0;
            double LunchCalorie = 0;
            double DinnerCalorie = 0;
            double SnackCalorie = 0;
        public void GetMealCalorie(Label lbl, int mealid, double calorie)
        {
            List<OperationData> MealCalorie = new List<OperationData>();
            MealCalorie = operationService.GetDailyResultsforMeal(user.UserID, date, mealid);
            foreach (OperationData item in MealCalorie)
            {
                calorie += item.Calorie;
            }
            lbl.Text = $"{calorie.ToString()} kcal";

        }


        private void btnBreakfast_Click(object sender, EventArgs e)
        {
            mealİD = 1;            
            frmFood frmFood = new frmFood(user, mealİD);
            frmFood.Show();
            this.Hide();

            //grdFoods.Columns["foodName"].HeaderText = "Yemek Adı";
            //grdFoods.Columns["portion"].HeaderText = "Porsiyon";
            //grdFoods.Columns["categorieName"].HeaderText = "Çeşit";
            //grdFoods.Columns["ID"].Visible = false;
            //grdFoods.Columns["calorie"].Visible = false;
            //grdFoods.Columns["carbohydrate"].Visible = false;
            //grdFoods.Columns["protein"].Visible = false;
            //grdFoods.Columns["fat"].Visible = false;
            //grdFoods.Columns["amount"].Visible = false;
        }

        private void btnLunch_Click(object sender, EventArgs e)
        {
            mealİD = 2;
            frmFood frmFood = new frmFood(user, mealİD);
            frmFood.Show();
            this.Hide();
        }

        private void btnDinner_Click(object sender, EventArgs e)
        {
            mealİD = 3;
            frmFood frmFood = new frmFood(user, mealİD);
            frmFood.Show();
            this.Hide();
        }

        private void btnSnack_Click(object sender, EventArgs e)
        {
            mealİD = 4;
            frmFood frmFood = new frmFood(user, mealİD);
            frmFood.Show();
            this.Hide();
        }


        private void lblBreakfast_Click(object sender, EventArgs e)
        {
            int mealid = 1;
            int userid = user.UserID;
            DateTime date = DateTime.Today;
            List<OperationData> MealFoodList = operationService.GetDataforMain(date, userid, mealid);
            grdFoods.DataSource = MealFoodList;
            ArrangeDataGridView();
        }


        private void lblLaunch_Click(object sender, EventArgs e)
        {
            int mealid = 2;
            int userid = user.UserID;
            DateTime date = DateTime.Today;
            List<OperationData> MealFoodList = operationService.GetDataforMain(date, userid, mealid);
            grdFoods.DataSource = MealFoodList;
            ArrangeDataGridView();
        }

        private void lblDinner_Click(object sender, EventArgs e)
        {
            int mealid = 3;
            int userid = user.UserID;
            DateTime date = DateTime.Today;
            List<OperationData> MealFoodList = operationService.GetDataforMain(date, userid, mealid);
            grdFoods.DataSource = MealFoodList;
            ArrangeDataGridView();
        }

        private void lblSnack_Click(object sender, EventArgs e)
        {
            int mealid = 4;
            int userid = user.UserID;
            DateTime date = DateTime.Today;
            List<OperationData> MealFoodList = operationService.GetDataforMain(date, userid, mealid);
            grdFoods.DataSource = MealFoodList;
            ArrangeDataGridView();
        }

        
        private void ArrangeDataGridView()
        {
            grdFoods.Columns["FoodID"].Visible = false;
            grdFoods.Columns["MealID"].Visible = false;
            grdFoods.Columns["UserID"].Visible = false;
            grdFoods.Columns["Portion"].Visible = false;
            grdFoods.Columns["carbohyrate"].Visible = false;
            grdFoods.Columns["Protein"].Visible = false;
            grdFoods.Columns["Fat"].Visible = false;
            grdFoods.Columns["MealName"].Visible = false;
            grdFoods.Columns["CategoryName"].Visible = false;
            grdFoods.Columns["Date"].Visible = false;
            grdFoods.Columns["UserName"].Visible = false;
            
        }

        private void btnPastRecords_Click(object sender, EventArgs e)
        {
            frmPastRecords frmPastRecords = new frmPastRecords(user);
            frmPastRecords.Show();
            this.Hide();

        }

        private void btnMealCompare_Click(object sender, EventArgs e)
        {
            frmCompare frmcompare = new frmCompare();
            frmcompare.Show();
            this.Hide();
            
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            frmSignUp signup = new frmSignUp(user);
            signup.Show();
            this.Hide();
        }
    }
}
