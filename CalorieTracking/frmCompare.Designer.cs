
namespace CalorieTracking
{
    partial class frmCompare
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
            this.dgvMealCompare = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMealCompare)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMealCompare
            // 
            this.dgvMealCompare.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMealCompare.Location = new System.Drawing.Point(12, 53);
            this.dgvMealCompare.Name = "dgvMealCompare";
            this.dgvMealCompare.RowHeadersWidth = 51;
            this.dgvMealCompare.RowTemplate.Height = 24;
            this.dgvMealCompare.Size = new System.Drawing.Size(663, 433);
            this.dgvMealCompare.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(92, 45);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "< Geri";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmCompare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 606);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgvMealCompare);
            this.Name = "frmCompare";
            this.Text = "frmCompare";
            this.Load += new System.EventHandler(this.frmCompare_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMealCompare)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMealCompare;
        private System.Windows.Forms.Button btnBack;
    }
}