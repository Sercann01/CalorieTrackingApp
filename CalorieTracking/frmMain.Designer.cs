
namespace CalorieTracking
{
    partial class frmMain
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
            this.gbSummary = new System.Windows.Forms.GroupBox();
            this.lblFat = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblProtein = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCarbonhydrate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCalorie = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblBreakfast = new System.Windows.Forms.Label();
            this.lblLaunch = new System.Windows.Forms.Label();
            this.lblSnack = new System.Windows.Forms.Label();
            this.lblDinner = new System.Windows.Forms.Label();
            this.btnBreakfast = new System.Windows.Forms.Button();
            this.grdFoods = new System.Windows.Forms.DataGridView();
            this.btnLunch = new System.Windows.Forms.Button();
            this.btnDinner = new System.Windows.Forms.Button();
            this.btnSnack = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblBreakfastSum = new System.Windows.Forms.Label();
            this.lblLunchSum = new System.Windows.Forms.Label();
            this.lblDinnerSum = new System.Windows.Forms.Label();
            this.lblSnackSum = new System.Windows.Forms.Label();
            this.btnPastRecords = new System.Windows.Forms.Button();
            this.btnMealCompare = new System.Windows.Forms.Button();
            this.btnUpdateUser = new System.Windows.Forms.Button();
            this.gbSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdFoods)).BeginInit();
            this.SuspendLayout();
            // 
            // gbSummary
            // 
            this.gbSummary.Controls.Add(this.lblFat);
            this.gbSummary.Controls.Add(this.label7);
            this.gbSummary.Controls.Add(this.lblProtein);
            this.gbSummary.Controls.Add(this.label5);
            this.gbSummary.Controls.Add(this.lblCarbonhydrate);
            this.gbSummary.Controls.Add(this.label3);
            this.gbSummary.Controls.Add(this.lblCalorie);
            this.gbSummary.Controls.Add(this.label1);
            this.gbSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbSummary.Location = new System.Drawing.Point(188, 37);
            this.gbSummary.Name = "gbSummary";
            this.gbSummary.Size = new System.Drawing.Size(768, 326);
            this.gbSummary.TabIndex = 0;
            this.gbSummary.TabStop = false;
            this.gbSummary.Text = "Özet Ekranı";
            // 
            // lblFat
            // 
            this.lblFat.AutoSize = true;
            this.lblFat.Location = new System.Drawing.Point(540, 229);
            this.lblFat.Name = "lblFat";
            this.lblFat.Size = new System.Drawing.Size(38, 20);
            this.lblFat.TabIndex = 7;
            this.lblFat.Text = "0 gr";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(540, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Yağ";
            // 
            // lblProtein
            // 
            this.lblProtein.AutoSize = true;
            this.lblProtein.Location = new System.Drawing.Point(318, 229);
            this.lblProtein.Name = "lblProtein";
            this.lblProtein.Size = new System.Drawing.Size(38, 20);
            this.lblProtein.TabIndex = 5;
            this.lblProtein.Text = "0 gr";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(318, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Protein";
            // 
            // lblCarbonhydrate
            // 
            this.lblCarbonhydrate.AutoSize = true;
            this.lblCarbonhydrate.Location = new System.Drawing.Point(87, 229);
            this.lblCarbonhydrate.Name = "lblCarbonhydrate";
            this.lblCarbonhydrate.Size = new System.Drawing.Size(38, 20);
            this.lblCarbonhydrate.TabIndex = 3;
            this.lblCarbonhydrate.Text = "0 gr";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Karbonhidrat";
            // 
            // lblCalorie
            // 
            this.lblCalorie.AutoSize = true;
            this.lblCalorie.Location = new System.Drawing.Point(318, 77);
            this.lblCalorie.Name = "lblCalorie";
            this.lblCalorie.Size = new System.Drawing.Size(53, 20);
            this.lblCalorie.TabIndex = 1;
            this.lblCalorie.Text = "0 kcal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(287, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Toplam Kalori";
            // 
            // lblBreakfast
            // 
            this.lblBreakfast.AutoSize = true;
            this.lblBreakfast.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBreakfast.Location = new System.Drawing.Point(70, 391);
            this.lblBreakfast.Name = "lblBreakfast";
            this.lblBreakfast.Size = new System.Drawing.Size(82, 25);
            this.lblBreakfast.TabIndex = 1;
            this.lblBreakfast.Text = "Kahvaltı";
            this.lblBreakfast.Click += new System.EventHandler(this.lblBreakfast_Click);
            // 
            // lblLaunch
            // 
            this.lblLaunch.AutoSize = true;
            this.lblLaunch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLaunch.Location = new System.Drawing.Point(69, 474);
            this.lblLaunch.Name = "lblLaunch";
            this.lblLaunch.Size = new System.Drawing.Size(125, 25);
            this.lblLaunch.TabIndex = 2;
            this.lblLaunch.Text = "Öğle Yemeği";
            this.lblLaunch.Click += new System.EventHandler(this.lblLaunch_Click);
            // 
            // lblSnack
            // 
            this.lblSnack.AutoSize = true;
            this.lblSnack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSnack.Location = new System.Drawing.Point(70, 638);
            this.lblSnack.Name = "lblSnack";
            this.lblSnack.Size = new System.Drawing.Size(105, 25);
            this.lblSnack.TabIndex = 3;
            this.lblSnack.Text = "Atıştırmalık";
            this.lblSnack.Click += new System.EventHandler(this.lblSnack_Click);
            // 
            // lblDinner
            // 
            this.lblDinner.AutoSize = true;
            this.lblDinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDinner.Location = new System.Drawing.Point(69, 557);
            this.lblDinner.Name = "lblDinner";
            this.lblDinner.Size = new System.Drawing.Size(144, 25);
            this.lblDinner.TabIndex = 4;
            this.lblDinner.Text = "Akşam Yemeği";
            this.lblDinner.Click += new System.EventHandler(this.lblDinner_Click);
            // 
            // btnBreakfast
            // 
            this.btnBreakfast.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBreakfast.Location = new System.Drawing.Point(244, 380);
            this.btnBreakfast.Name = "btnBreakfast";
            this.btnBreakfast.Size = new System.Drawing.Size(119, 50);
            this.btnBreakfast.TabIndex = 5;
            this.btnBreakfast.Text = "Seç";
            this.btnBreakfast.UseVisualStyleBackColor = true;
            this.btnBreakfast.Click += new System.EventHandler(this.btnBreakfast_Click);
            // 
            // grdFoods
            // 
            this.grdFoods.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdFoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdFoods.Location = new System.Drawing.Point(553, 369);
            this.grdFoods.Name = "grdFoods";
            this.grdFoods.RowHeadersWidth = 51;
            this.grdFoods.RowTemplate.Height = 24;
            this.grdFoods.Size = new System.Drawing.Size(481, 335);
            this.grdFoods.TabIndex = 13;
            // 
            // btnLunch
            // 
            this.btnLunch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLunch.Location = new System.Drawing.Point(244, 463);
            this.btnLunch.Name = "btnLunch";
            this.btnLunch.Size = new System.Drawing.Size(119, 50);
            this.btnLunch.TabIndex = 14;
            this.btnLunch.Text = "Seç";
            this.btnLunch.UseVisualStyleBackColor = true;
            this.btnLunch.Click += new System.EventHandler(this.btnLunch_Click);
            // 
            // btnDinner
            // 
            this.btnDinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDinner.Location = new System.Drawing.Point(244, 546);
            this.btnDinner.Name = "btnDinner";
            this.btnDinner.Size = new System.Drawing.Size(119, 50);
            this.btnDinner.TabIndex = 15;
            this.btnDinner.Text = "Seç";
            this.btnDinner.UseVisualStyleBackColor = true;
            this.btnDinner.Click += new System.EventHandler(this.btnDinner_Click);
            // 
            // btnSnack
            // 
            this.btnSnack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSnack.Location = new System.Drawing.Point(244, 627);
            this.btnSnack.Name = "btnSnack";
            this.btnSnack.Size = new System.Drawing.Size(119, 50);
            this.btnSnack.TabIndex = 16;
            this.btnSnack.Text = "Seç";
            this.btnSnack.UseVisualStyleBackColor = true;
            this.btnSnack.Click += new System.EventHandler(this.btnSnack_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(439, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Hoşgeldin";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblName.Location = new System.Drawing.Point(570, 17);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(62, 20);
            this.lblName.TabIndex = 18;
            this.lblName.Text = "label10";
            // 
            // lblBreakfastSum
            // 
            this.lblBreakfastSum.AutoSize = true;
            this.lblBreakfastSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBreakfastSum.Location = new System.Drawing.Point(425, 391);
            this.lblBreakfastSum.Name = "lblBreakfastSum";
            this.lblBreakfastSum.Size = new System.Drawing.Size(82, 25);
            this.lblBreakfastSum.TabIndex = 19;
            this.lblBreakfastSum.Text = "Kahvaltı";
            // 
            // lblLunchSum
            // 
            this.lblLunchSum.AutoSize = true;
            this.lblLunchSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLunchSum.Location = new System.Drawing.Point(425, 474);
            this.lblLunchSum.Name = "lblLunchSum";
            this.lblLunchSum.Size = new System.Drawing.Size(82, 25);
            this.lblLunchSum.TabIndex = 20;
            this.lblLunchSum.Text = "Kahvaltı";
            // 
            // lblDinnerSum
            // 
            this.lblDinnerSum.AutoSize = true;
            this.lblDinnerSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDinnerSum.Location = new System.Drawing.Point(425, 557);
            this.lblDinnerSum.Name = "lblDinnerSum";
            this.lblDinnerSum.Size = new System.Drawing.Size(82, 25);
            this.lblDinnerSum.TabIndex = 21;
            this.lblDinnerSum.Text = "Kahvaltı";
            // 
            // lblSnackSum
            // 
            this.lblSnackSum.AutoSize = true;
            this.lblSnackSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSnackSum.Location = new System.Drawing.Point(425, 638);
            this.lblSnackSum.Name = "lblSnackSum";
            this.lblSnackSum.Size = new System.Drawing.Size(82, 25);
            this.lblSnackSum.TabIndex = 22;
            this.lblSnackSum.Text = "Kahvaltı";
            // 
            // btnPastRecords
            // 
            this.btnPastRecords.Location = new System.Drawing.Point(12, 37);
            this.btnPastRecords.Name = "btnPastRecords";
            this.btnPastRecords.Size = new System.Drawing.Size(109, 47);
            this.btnPastRecords.TabIndex = 23;
            this.btnPastRecords.Text = "Geçmiş Kayıtlar";
            this.btnPastRecords.UseVisualStyleBackColor = true;
            this.btnPastRecords.Click += new System.EventHandler(this.btnPastRecords_Click);
            // 
            // btnMealCompare
            // 
            this.btnMealCompare.Location = new System.Drawing.Point(12, 90);
            this.btnMealCompare.Name = "btnMealCompare";
            this.btnMealCompare.Size = new System.Drawing.Size(109, 67);
            this.btnMealCompare.TabIndex = 24;
            this.btnMealCompare.Text = "Öğün Karşılaştırma Tablosu";
            this.btnMealCompare.UseVisualStyleBackColor = true;
            this.btnMealCompare.Click += new System.EventHandler(this.btnMealCompare_Click);
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.Location = new System.Drawing.Point(12, 163);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(109, 64);
            this.btnUpdateUser.TabIndex = 25;
            this.btnUpdateUser.Text = "Kullanıcı Güncelle";
            this.btnUpdateUser.UseVisualStyleBackColor = true;
            this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 771);
            this.Controls.Add(this.btnUpdateUser);
            this.Controls.Add(this.btnMealCompare);
            this.Controls.Add(this.btnPastRecords);
            this.Controls.Add(this.lblSnackSum);
            this.Controls.Add(this.lblDinnerSum);
            this.Controls.Add(this.lblLunchSum);
            this.Controls.Add(this.lblBreakfastSum);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnSnack);
            this.Controls.Add(this.btnDinner);
            this.Controls.Add(this.btnLunch);
            this.Controls.Add(this.grdFoods);
            this.Controls.Add(this.btnBreakfast);
            this.Controls.Add(this.lblDinner);
            this.Controls.Add(this.lblSnack);
            this.Controls.Add(this.lblLaunch);
            this.Controls.Add(this.lblBreakfast);
            this.Controls.Add(this.gbSummary);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.gbSummary.ResumeLayout(false);
            this.gbSummary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdFoods)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSummary;
        private System.Windows.Forms.Label lblFat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblProtein;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCarbonhydrate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCalorie;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblBreakfast;
        private System.Windows.Forms.Label lblLaunch;
        private System.Windows.Forms.Label lblSnack;
        private System.Windows.Forms.Label lblDinner;
        private System.Windows.Forms.Button btnBreakfast;
        private System.Windows.Forms.DataGridView grdFoods;
        private System.Windows.Forms.Button btnLunch;
        private System.Windows.Forms.Button btnDinner;
        private System.Windows.Forms.Button btnSnack;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblBreakfastSum;
        private System.Windows.Forms.Label lblLunchSum;
        private System.Windows.Forms.Label lblDinnerSum;
        private System.Windows.Forms.Label lblSnackSum;
        private System.Windows.Forms.Button btnPastRecords;
        private System.Windows.Forms.Button btnMealCompare;
        private System.Windows.Forms.Button btnUpdateUser;
    }
}