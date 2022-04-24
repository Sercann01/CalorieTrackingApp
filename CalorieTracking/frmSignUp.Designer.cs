
namespace CalorieTracking
{
    partial class frmSignUp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbSignUp = new System.Windows.Forms.GroupBox();
            this.cbgoster = new System.Windows.Forms.CheckBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.cmbSportBackground = new System.Windows.Forms.ComboBox();
            this.cmbAge = new System.Windows.Forms.ComboBox();
            this.cmbWeight = new System.Windows.Forms.ComboBox();
            this.cmbHeight = new System.Windows.Forms.ComboBox();
            this.rbWoman = new System.Windows.Forms.RadioButton();
            this.rbMan = new System.Windows.Forms.RadioButton();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserMail = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnBack = new System.Windows.Forms.Button();
            this.gbSignUp.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSignUp
            // 
            this.gbSignUp.Controls.Add(this.cbgoster);
            this.gbSignUp.Controls.Add(this.lblPassword);
            this.gbSignUp.Controls.Add(this.btnSave);
            this.gbSignUp.Controls.Add(this.cmbSportBackground);
            this.gbSignUp.Controls.Add(this.cmbAge);
            this.gbSignUp.Controls.Add(this.cmbWeight);
            this.gbSignUp.Controls.Add(this.cmbHeight);
            this.gbSignUp.Controls.Add(this.rbWoman);
            this.gbSignUp.Controls.Add(this.rbMan);
            this.gbSignUp.Controls.Add(this.txtPassword);
            this.gbSignUp.Controls.Add(this.txtUserMail);
            this.gbSignUp.Controls.Add(this.txtSurname);
            this.gbSignUp.Controls.Add(this.txtName);
            this.gbSignUp.Controls.Add(this.label9);
            this.gbSignUp.Controls.Add(this.label8);
            this.gbSignUp.Controls.Add(this.label7);
            this.gbSignUp.Controls.Add(this.label6);
            this.gbSignUp.Controls.Add(this.label5);
            this.gbSignUp.Controls.Add(this.label4);
            this.gbSignUp.Controls.Add(this.label3);
            this.gbSignUp.Controls.Add(this.label2);
            this.gbSignUp.Controls.Add(this.label1);
            this.gbSignUp.Location = new System.Drawing.Point(35, 54);
            this.gbSignUp.Margin = new System.Windows.Forms.Padding(4);
            this.gbSignUp.Name = "gbSignUp";
            this.gbSignUp.Padding = new System.Windows.Forms.Padding(4);
            this.gbSignUp.Size = new System.Drawing.Size(526, 558);
            this.gbSignUp.TabIndex = 0;
            this.gbSignUp.TabStop = false;
            this.gbSignUp.Text = "Kayıt Ekranı";
            // 
            // cbgoster
            // 
            this.cbgoster.AutoSize = true;
            this.cbgoster.Location = new System.Drawing.Point(436, 418);
            this.cbgoster.Name = "cbgoster";
            this.cbgoster.Size = new System.Drawing.Size(23, 21);
            this.cbgoster.TabIndex = 22;
            this.cbgoster.UseVisualStyleBackColor = true;
            this.cbgoster.CheckedChanged += new System.EventHandler(this.cbgoster_CheckedChanged_1);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(360, 445);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(89, 20);
            this.lblPassword.TabIndex = 21;
            this.lblPassword.Text = "Şifre Gücü";
            this.lblPassword.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(209, 492);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(213, 46);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Kayıt Ol";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbSportBackground
            // 
            this.cmbSportBackground.FormattingEnabled = true;
            this.cmbSportBackground.Location = new System.Drawing.Point(209, 321);
            this.cmbSportBackground.Name = "cmbSportBackground";
            this.cmbSportBackground.Size = new System.Drawing.Size(213, 28);
            this.cmbSportBackground.TabIndex = 18;
            // 
            // cmbAge
            // 
            this.cmbAge.FormattingEnabled = true;
            this.cmbAge.Location = new System.Drawing.Point(209, 276);
            this.cmbAge.Name = "cmbAge";
            this.cmbAge.Size = new System.Drawing.Size(213, 28);
            this.cmbAge.TabIndex = 17;
            // 
            // cmbWeight
            // 
            this.cmbWeight.FormattingEnabled = true;
            this.cmbWeight.Location = new System.Drawing.Point(209, 234);
            this.cmbWeight.Name = "cmbWeight";
            this.cmbWeight.Size = new System.Drawing.Size(213, 28);
            this.cmbWeight.TabIndex = 16;
            // 
            // cmbHeight
            // 
            this.cmbHeight.FormattingEnabled = true;
            this.cmbHeight.Location = new System.Drawing.Point(209, 191);
            this.cmbHeight.Name = "cmbHeight";
            this.cmbHeight.Size = new System.Drawing.Size(213, 28);
            this.cmbHeight.TabIndex = 15;
            // 
            // rbWoman
            // 
            this.rbWoman.AutoSize = true;
            this.rbWoman.Location = new System.Drawing.Point(340, 154);
            this.rbWoman.Name = "rbWoman";
            this.rbWoman.Size = new System.Drawing.Size(72, 24);
            this.rbWoman.TabIndex = 14;
            this.rbWoman.Text = "Kadın";
            this.rbWoman.UseVisualStyleBackColor = true;
            // 
            // rbMan
            // 
            this.rbMan.AutoSize = true;
            this.rbMan.Checked = true;
            this.rbMan.Location = new System.Drawing.Point(209, 154);
            this.rbMan.Name = "rbMan";
            this.rbMan.Size = new System.Drawing.Size(72, 24);
            this.rbMan.TabIndex = 13;
            this.rbMan.TabStop = true;
            this.rbMan.Text = "Erkek";
            this.rbMan.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(209, 415);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(213, 27);
            this.txtPassword.TabIndex = 12;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // txtUserMail
            // 
            this.txtUserMail.Location = new System.Drawing.Point(209, 370);
            this.txtUserMail.Name = "txtUserMail";
            this.txtUserMail.Size = new System.Drawing.Size(213, 27);
            this.txtUserMail.TabIndex = 11;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(209, 114);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(213, 27);
            this.txtSurname.TabIndex = 10;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(209, 73);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(213, 27);
            this.txtName.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(45, 418);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Şifre : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 373);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Kullanıcı Maili : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 279);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Yaş : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 324);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Spor Geçmişi :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Kilo : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Boy : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cinsiyet : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyisim : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "İsim :";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 13);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 34);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "< Geri";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 635);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.gbSignUp);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSignUp";
            this.Text = "frmSignUp";
            this.Load += new System.EventHandler(this.frmSignUp_Load);
            this.gbSignUp.ResumeLayout(false);
            this.gbSignUp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSignUp;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cmbSportBackground;
        private System.Windows.Forms.ComboBox cmbAge;
        private System.Windows.Forms.ComboBox cmbWeight;
        private System.Windows.Forms.ComboBox cmbHeight;
        private System.Windows.Forms.RadioButton rbWoman;
        private System.Windows.Forms.RadioButton rbMan;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserMail;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.CheckBox cbgoster;
        private System.Windows.Forms.Button btnBack;
    }
}