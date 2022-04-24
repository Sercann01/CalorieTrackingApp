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
    public partial class frmFood : Form
    {
        public frmFood()
        {
            InitializeComponent();           
        }

        public frmFood(User  user1, int mealid)
        {
            InitializeComponent();
            user = user1;
            Userid = user.UserID;
            Mealid = mealid;
          
        }

        frmSignUp frmSignUp = new frmSignUp();
        FoodService foodService = new FoodService();
        OperationService operationService = new OperationService();
        int Userid;
        int Mealid;
        User user;
        DateTime date = DateTime.Today;

        private void frmFood_Load(object sender, EventArgs e)
        {
            dgvSearchedFoods.DataSource = foodService.ListAllFoods();
            FillDataGridView(dgvSearchedFoods);
            dgvSelectedFoods.DataSource = operationService.GetDataforMain(date, Userid, Mealid);
            FillSelectedDataGridView(dgvSelectedFoods);           
            FillCombobox(cmbAmount, 0.5, 10);
        }

        
        private void btnAdd_Click(object sender, EventArgs e)
        {

            Food temporaryFood = new Food();
            cmbAmount.ResetText();
            int FoodID = Convert.ToInt32(dgvSearchedFoods.SelectedRows[0].Cells[0].Value);

            List<OperationData> MealFoodList = operationService.GetDataforMain(date, Userid, Mealid);
            foreach (OperationData item in MealFoodList)
            {
                if (item.FoodID == FoodID)
                {
                    MessageBox.Show("Aynı üründen daha önce giriş yapmıştınız. Lütfen istediğiniz miktarı güncelleyiniz.");
                    return;
                }
            }

            double amount = Convert.ToDouble(cmbAmount.SelectedItem);
            temporaryFood = foodService.GetFoodsbyID(FoodID);

            Operation op = new Operation()
            {
                Amount = amount,
                Date = DateTime.Today,
                UserID = Userid,
                FoodID = temporaryFood.FoodID,
                MealID = Mealid,
            };
            bool check;
            check = operationService.Insert(op);
            MessageBox.Show(check ? " Ürün eklendi " : " Ürün eklenememiştir.");

            MealFoodList = operationService.GetDataforMain(date, Userid, Mealid);
            dgvSelectedFoods.DataSource = MealFoodList;
            FillSelectedDataGridView(dgvSelectedFoods);
        }

        List<OperationData> MealFoodList;
        
        public void btnDelete_Click(object sender, EventArgs e)
        {
            int FoodID = Convert.ToInt32(dgvSelectedFoods.SelectedRows[0].Cells[1].Value);
            bool check = operationService.Delete(Userid, date, Mealid, FoodID);
            if (check)
            {
                MessageBox.Show("Ürün Silinmiştir.");
            }
            else
            {
                MessageBox.Show("Ürün Silinmemiştir.");
            }
            MealFoodList = operationService.GetDataforMain(date, Userid, Mealid);
            dgvSelectedFoods.DataSource = MealFoodList;
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMain frmMain = new frmMain(user);
            frmMain.Show();
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int FoodID = Convert.ToInt32(dgvSelectedFoods.SelectedRows[0].Cells[1].Value);
                int newAmount = Convert.ToInt32(cmbAmount.SelectedItem);
                if (newAmount == 0)
                {
                    MessageBox.Show("Güncelleyeceğiniz ürünün adetini seçiniz.");
                    return;
                }
                bool check = operationService.Update(newAmount, date, Userid, Mealid, FoodID);
                if (check)
                {
                    MessageBox.Show("Ürün güncellenmiştir.");
                }
                else
                {
                    MessageBox.Show("Ürün güncellenmemiştir.");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            cmbAmount.ResetText();
            MealFoodList = operationService.GetDataforMain(date, Userid, Mealid);
            dgvSelectedFoods.DataSource = MealFoodList;

        }
        private void FillDataGridView(DataGridView dgv)
        {
            dgv.Columns["Category"].Visible = false;
            dgv.Columns["Operations"].Visible = false;
            dgv.Columns["FoodID"].Visible = false;
            dgv.Columns["CategoryID"].Visible = false;
            dgv.Columns["Amount"].HeaderText = "Amount(gr)";
        }
        private void FillSelectedDataGridView(DataGridView dgv)
        {
            dgvSelectedFoods.Columns["OperationID"].Visible = false;
            dgvSelectedFoods.Columns["MealID"].Visible = false;
            dgvSelectedFoods.Columns["UserID"].Visible = false;
            dgvSelectedFoods.Columns["MealName"].Visible = false;
            dgvSelectedFoods.Columns["CategoryName"].Visible = false;
            dgvSelectedFoods.Columns["Date"].Visible = false;
            dgvSelectedFoods.Columns["UserName"].Visible = false;
            dgvSelectedFoods.Columns["FoodID"].Visible = false;
            
        }

        private void txtFoodSearch_TextChanged(object sender, EventArgs e)
        {
            string searchedtext = txtFoodSearch.Text;
            List<Food> SearchedFood = new List<Food>();
            SearchedFood = foodService.GetFoodsbyString(searchedtext);
            dgvSearchedFoods.DataSource = SearchedFood;
        }

        private void FillCombobox(ComboBox combobox, double min, double max) 
        {
            for (double i = min; i <= max; i = i+ 0.5)
            {
                combobox.Items.Add(i);
            }
        }

    }
}
