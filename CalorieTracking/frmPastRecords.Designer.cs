
namespace CalorieTracking
{
    partial class frmPastRecords
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
            this.mcCalender = new System.Windows.Forms.MonthCalendar();
            this.dgvPastRecords = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPastRecords)).BeginInit();
            this.SuspendLayout();
            // 
            // mcCalender
            // 
            this.mcCalender.Location = new System.Drawing.Point(333, 18);
            this.mcCalender.MaxSelectionCount = 1;
            this.mcCalender.Name = "mcCalender";
            this.mcCalender.TabIndex = 0;
            this.mcCalender.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mcCalender_DateChanged);
            // 
            // dgvPastRecords
            // 
            this.dgvPastRecords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPastRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPastRecords.Location = new System.Drawing.Point(174, 248);
            this.dgvPastRecords.Name = "dgvPastRecords";
            this.dgvPastRecords.RowHeadersWidth = 51;
            this.dgvPastRecords.RowTemplate.Height = 24;
            this.dgvPastRecords.Size = new System.Drawing.Size(575, 294);
            this.dgvPastRecords.TabIndex = 1;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(33, 26);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(88, 38);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "< Geri";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmPastRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 626);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgvPastRecords);
            this.Controls.Add(this.mcCalender);
            this.Name = "frmPastRecords";
            this.Text = "frmPastRecords";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPastRecords)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar mcCalender;
        private System.Windows.Forms.DataGridView dgvPastRecords;
        private System.Windows.Forms.Button btnBack;
    }
}