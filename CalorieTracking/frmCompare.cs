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
    public partial class frmCompare : Form
    {
        public frmCompare()
        {
            InitializeComponent();
        }
        public frmCompare(User User)
        {
            InitializeComponent();
            user = User;
        }
        User user;
        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMain frmmain = new frmMain(user);
            frmmain.Show();
            this.Hide();
        }
        Dictionary<string, List<string>> CompareList = new Dictionary<string, List<string>>();
        private void frmCompare_Load(object sender, EventArgs e)
        {
            //Dictionary<string, List<string>> CompareList = new Dictionary<string, List<string>>();



        }
    }
}
