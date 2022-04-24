using CalorieBLL.Services;
using CalorieBLL;
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
using CalorieMODEL.Data_Transfer;

namespace CalorieTracking
{
    public partial class frmPastRecords : Form
    {
        public frmPastRecords()
        {
            InitializeComponent();
            userService = new UserService();
            operationService = new OperationService();
            
        }
        OperationService operationService;
        UserService userService;
        User user;

        public frmPastRecords(User User)
        {
            user = User;
            InitializeComponent();
            userService = new UserService();
            operationService = new OperationService();
        }


        //public void mcCalender_DateChanged(object sender, DateRangeEventArgs e)
        //{
        //    DateTime datetime;
        //    datetime = mcCalender.TodayDate;

        //    operationService.GetSelectedFoods(datetime, )

        //}
        //List<FullList> FullList1;
        
        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMain MainForm = new frmMain(user);
            MainForm.Show();
            this.Hide();
        }

        private void mcCalender_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime datetime;
            datetime = (DateTime)(mcCalender.SelectionStart);

            int userid = user.UserID;
            List<OperationData> ListPastRecords = operationService.GetDataforPastRecords(datetime, userid).ToList();
            dgvPastRecords.DataSource = ListPastRecords;
            dgvPastRecords.Columns["OperationID"].Visible = false;
            dgvPastRecords.Columns["FoodID"].Visible = false;
            dgvPastRecords.Columns["MealID"].Visible = false;
            dgvPastRecords.Columns["UserID"].Visible = false;
            dgvPastRecords.Columns["Portion"].Visible = false;
            dgvPastRecords.Columns["carbohyrate"].Visible = false;
            dgvPastRecords.Columns["Protein"].Visible = false;
            dgvPastRecords.Columns["Fat"].Visible = false;
            dgvPastRecords.Columns["CategoryName"].Visible = false;
            dgvPastRecords.Columns["UserName"].Visible = false;
            
        }
    }
}
