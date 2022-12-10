namespace ProductManagement
{
    partial class MonthlyIncomeForm
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
            this.incomeDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.incomeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // incomeDataGridView
            // 
            this.incomeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.incomeDataGridView.Location = new System.Drawing.Point(174, 71);
            this.incomeDataGridView.Name = "incomeDataGridView";
            this.incomeDataGridView.Size = new System.Drawing.Size(530, 683);
            this.incomeDataGridView.TabIndex = 0;
            // 
            // MonthlyIncomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 818);
            this.Controls.Add(this.incomeDataGridView);
            this.Name = "MonthlyIncomeForm";
            this.Text = "MonthlyIncomeForm";
            this.Load += new System.EventHandler(this.MonthlyIncomeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.incomeDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView incomeDataGridView;
    }
}
