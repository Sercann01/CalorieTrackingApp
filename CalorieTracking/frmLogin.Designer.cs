
namespace CalorieTracking
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.grbLoginScreen = new System.Windows.Forms.GroupBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblSave = new System.Windows.Forms.LinkLabel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserMail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cbSecretPassword = new System.Windows.Forms.CheckBox();
            this.grbLoginScreen.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbLoginScreen
            // 
            this.grbLoginScreen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("grbLoginScreen.BackgroundImage")));
            this.grbLoginScreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grbLoginScreen.Controls.Add(this.cbSecretPassword);
            this.grbLoginScreen.Controls.Add(this.btnLogin);
            this.grbLoginScreen.Controls.Add(this.lblSave);
            this.grbLoginScreen.Controls.Add(this.txtPassword);
            this.grbLoginScreen.Controls.Add(this.txtUserMail);
            this.grbLoginScreen.Controls.Add(this.label2);
            this.grbLoginScreen.Controls.Add(this.label1);
            this.grbLoginScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbLoginScreen.Location = new System.Drawing.Point(0, 0);
            this.grbLoginScreen.Name = "grbLoginScreen";
            this.grbLoginScreen.Size = new System.Drawing.Size(505, 389);
            this.grbLoginScreen.TabIndex = 6;
            this.grbLoginScreen.TabStop = false;
            this.grbLoginScreen.Text = "Giriş Ekranı";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(274, 200);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(100, 44);
            this.btnLogin.TabIndex = 13;
            this.btnLogin.Text = "Giriş Yap";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click_1);
            // 
            // lblSave
            // 
            this.lblSave.AutoSize = true;
            this.lblSave.Location = new System.Drawing.Point(126, 264);
            this.lblSave.Name = "lblSave";
            this.lblSave.Size = new System.Drawing.Size(204, 20);
            this.lblSave.TabIndex = 12;
            this.lblSave.TabStop = true;
            this.lblSave.Text = "Kayıt Olmak İçin Tıklayınız";
            this.lblSave.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblSave_LinkClicked);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(184, 126);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(190, 27);
            this.txtPassword.TabIndex = 9;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // txtUserMail
            // 
            this.txtUserMail.Location = new System.Drawing.Point(184, 72);
            this.txtUserMail.Name = "txtUserMail";
            this.txtUserMail.Size = new System.Drawing.Size(190, 27);
            this.txtUserMail.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 126);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Şifre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Kullanıcı Maili";
            // 
            // cbSecretPassword
            // 
            this.cbSecretPassword.AutoSize = true;
            this.cbSecretPassword.Location = new System.Drawing.Point(308, 159);
            this.cbSecretPassword.Name = "cbSecretPassword";
            this.cbSecretPassword.Size = new System.Drawing.Size(113, 24);
            this.cbSecretPassword.TabIndex = 14;
            this.cbSecretPassword.Text = "checkBox1";
            this.cbSecretPassword.UseVisualStyleBackColor = true;
            this.cbSecretPassword.CheckedChanged += new System.EventHandler(this.cbSecretPassword_CheckedChanged);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 389);
            this.Controls.Add(this.grbLoginScreen);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLogin";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.grbLoginScreen.ResumeLayout(false);
            this.grbLoginScreen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbLoginScreen;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserMail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.LinkLabel lblSave;
        private System.Windows.Forms.CheckBox cbSecretPassword;
    }
}

