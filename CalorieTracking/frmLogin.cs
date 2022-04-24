using CalorieBLL.Services;
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
    public partial class frmLogin : Form
    {
        UserService userService;
        public frmLogin()
        {
            InitializeComponent();
            userService = new UserService();
        }
        

        private void lblSave_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmSignUp frmSignUp = new frmSignUp();
            frmSignUp.Show();
            this.Hide();
        }
        User user;
        

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            try
            {
                string userMail = txtUserMail.Text;
                string Password = txtPassword.Text;

                user = userService.CheckLogin(userMail, Password);

                if (user != null)
                {
                    frmMain frmMain = new frmMain(user);
                    frmMain.Show();
                    this.Hide();

                }
                else
                {
                    txtPassword.Text = null;
                    txtUserMail.Text = null;
                    MessageBox.Show("Lütfen kullanıcı bilgilerini kontrol ediniz, eksik yada yanlış giriş yaptınız.");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public User GetUser()
        {
            return user;
        }

        private void cbSecretPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSecretPassword.CheckState == CheckState.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
                cbSecretPassword.Text = "Gizle";

            }
            else if (cbSecretPassword.CheckState == CheckState.Unchecked)
            {
                txtPassword.UseSystemPasswordChar = true;
                cbSecretPassword.Text = "Göster";
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            cbSecretPassword.Text = "Göster";
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            cbSecretPassword.Text = "Göster";
        }
    }
}
