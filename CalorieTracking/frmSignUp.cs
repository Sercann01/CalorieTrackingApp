using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalorieBLL.Services;
using CalorieMODEL.Entities;
using CalorieMODEL.Enums;


namespace CalorieTracking
{
    public partial class frmSignUp : Form
    {
        public frmSignUp()
        {
            InitializeComponent();
            userService = new UserService();
            
        }

        public frmSignUp(User User)
        {
            userSaved = User;
            InitializeComponent();
            userService = new UserService();

            txtName.Text = User.Name;
            txtSurname.Text = User.Surname;
            if (User.Gender == "Kadın")
            {
                rbWoman.Checked = true;
            }
            else
            {
                rbMan.Checked = true;
            }
            FillCombobox(cmbHeight, 100, 250);
            FillCombobox(cmbWeight, 40, 150);
            FillCombobox(cmbAge, 10, 70);
            foreach (var item1 in Enum.GetNames(typeof(SportBackgroundType)))
            {
                cmbSportBackground.Items.Add(item1);
            }
            cmbHeight.SelectedItem = Convert.ToInt32(User.Height);
            cmbWeight.SelectedItem = Convert.ToInt32(User.Weight);
            cmbAge.SelectedItem = User.Age;
            cmbSportBackground.SelectedItem = User.SportBackground;
            txtUserMail.Text = User.Usermail;
            txtPassword.Text = User.Password;
            txtPassword.UseSystemPasswordChar = false;
            btnSave.Text = "Güncelle";

        }
        UserService userService;
        User userSaved;

        private void frmSignUp_Load(object sender, EventArgs e)
        {
            if (userSaved !=null)
            {
                return;
            }
            FillCombobox(cmbHeight, 100, 250);
            FillCombobox(cmbWeight, 40, 150);
            FillCombobox(cmbAge, 10, 70);
            foreach (var item in Enum.GetNames(typeof(SportBackgroundType)))
            {
                cmbSportBackground.Items.Add(item);
            }
        }

        public void FillCombobox(ComboBox combobox, int min, int max)
        {
            for (int i = min; i < max; i++)
            {
                combobox.Items.Add(i);
            }
        }



        bool UserUpdateCheck = false;
        User newuser;
        private void btnSave_Click(object sender, EventArgs e)
        {
            bool issavedbefore = false;
            if (userSaved != null)
            {
                issavedbefore = true;
            }

            try
            {
                User user = new User()
                {
                    Name = txtName.Text,
                    Surname = txtSurname.Text,
                    Usermail = txtUserMail.Text,
                    Password = txtPassword.Text
                };
                if (rbMan.Checked)
                {
                    user.Gender = "Erkek";
                }
                else
                {
                    user.Gender = "Kadın";
                }
                user.Height = Convert.ToDouble(cmbHeight.SelectedItem);
                user.Weight = Convert.ToDouble(cmbWeight.SelectedItem);
                user.Age = Convert.ToInt32(cmbAge.SelectedItem);                
                user.SportBackground = (string)cmbSportBackground.SelectedItem;
                
                bool UserInsertCheck = false;
                bool update = false;
                bool insert = false;


                if (userService.PasswordCheckControl(user.Password) && userService.UserMailControl(user.Usermail))
                {
                    if (issavedbefore)
                    {
                        UserUpdateCheck = userService.Update(user, userSaved.UserID);
                        update = true;
                    }
                    else
                    {
                        UserInsertCheck = userService.Insert(user);
                        insert = true;
                            
                    }
                }
                else if (! userService.PasswordCheckControl(user.Password) && userService.UserMailControl(user.Usermail))
                {
                    MessageBox.Show("Daha Güçlü bir şifre yazınız.");
                    return;
                }
                else if (userService.PasswordCheckControl(user.Password) && ! userService.UserMailControl(user.Usermail))
                {
                    MessageBox.Show("Gerçek bir mail adresi giriniz.");
                    return;
                }
                else
                {
                    MessageBox.Show("Hem kullanıcı mailinizde hem de belirlediğiniz şifrede hata var.");
                    return;
                }

                if (update)
                {
                    MessageBox.Show(UserUpdateCheck ? "Güncelleme Gerçekleşmiştir." : "Güncelleme Gerçekleşmemiştir.");

                }
                else if (insert)
                {
                    MessageBox.Show(UserInsertCheck ? "Kayıt Gerçekleşmiştir." : "Kayıt Gerçekleşmemiştir.");
                }
                if (UserInsertCheck)
                {
                    frmLogin frmLogin = new frmLogin();
                    frmLogin.Show();
                    this.Hide();
                }
                if (UserUpdateCheck)
                {
                    newuser = userService.CheckLogin(userSaved.UserID);
                    frmMain frmmain = new frmMain(newuser);
                    frmmain.Show();
                    this.Hide();
                    return;
                }
                else
                {
                    foreach (Control item in gbSignUp.Controls)
                    {
                        if (item is ComboBox)
                        {
                            ((ComboBox)item).ResetText();
                            FillCombobox(cmbHeight, 100, 250);
                            FillCombobox(cmbWeight, 40, 150);
                            FillCombobox(cmbAge, 10, 70);
                            foreach (var item1 in Enum.GetNames(typeof(SportBackgroundType)))
                            {
                                cmbSportBackground.Items.Add(item);
                            }
                        }
                        if (item is TextBox)
                        {
                            ((TextBox)item).Text = null;
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Kayıt gerçekleşirken bir hata oluşmuştur. Girdiğiniz kullanıcı maili daha önceden kaydedilmiş olabilir.");    
            }


        }

        private void button1_Click(object sender, EventArgs e)   // Test için oluşturulmuştur.
        {
            cmbHeight.ResetText();
        }


        bool PasswordCheck = false;
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            //if (userSaved != null)
            //{
            //    return;
            //}

            cbgoster.Text = "Göster";
            txtPassword.UseSystemPasswordChar = true;
            lblPassword.Visible = true;
            string password = txtPassword.Text;
            int PasswordStrengthControl = userService.PasswordStrengthControl(password);

            if (PasswordStrengthControl == 1)
            {
                lblPassword.Text = "Güçlü";
                lblPassword.BackColor = Color.Green;
                PasswordCheck = true;

            }
            else if (PasswordStrengthControl == 2)
            {
                lblPassword.Text = "Orta";
                lblPassword.BackColor = Color.Yellow;
                PasswordCheck = false;
            }
            else if (PasswordStrengthControl == 3)
            {
                lblPassword.Text = "Zayıf";
                lblPassword.BackColor = Color.Red;
                PasswordCheck = false;
            }
            else
            {
                lblPassword.Visible = false;
            }

        }

      

        private void cbgoster_CheckedChanged_1(object sender, EventArgs e)
        {
            
            if (cbgoster.CheckState == CheckState.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
                cbgoster.Text = "Gizle";

            }
            else if (cbgoster.CheckState == CheckState.Unchecked)
            {
                txtPassword.UseSystemPasswordChar = true;
                cbgoster.Text = "Göster";
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (userSaved != null)
            {
                if (UserUpdateCheck)
                {
                    frmMain frmmain = new frmMain(newuser);
                    frmmain.Show();
                    this.Hide();
                    return;
                }
                else
                {
                    frmMain frmmain = new frmMain(userSaved);
                    frmmain.Show();
                    this.Hide();
                    return;
                }

            }
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
            this.Hide();
        }
    }
}
