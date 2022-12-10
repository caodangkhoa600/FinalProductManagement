namespace ProductManagement
{
    partial class BestSellingForm
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
            this.bestSellingDataGridView = new System.Windows.Forms.DataGridView();
            this.reloadBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.toDatePicker = new System.Windows.Forms.DateTimePicker();
            this.fromDatePicker = new System.Windows.Forms.DateTimePicker();
            this.filterBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bestSellingDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bestSellingDataGridView
            // 
            this.bestSellingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bestSellingDataGridView.Location = new System.Drawing.Point(158, 86);
            this.bestSellingDataGridView.Name = "bestSellingDataGridView";
            this.bestSellingDataGridView.Size = new System.Drawing.Size(870, 543);
            this.bestSellingDataGridView.TabIndex = 0;
            // 
            // reloadBtn
            // 
            this.reloadBtn.Location = new System.Drawing.Point(931, 33);
            this.reloadBtn.Name = "reloadBtn";
            this.reloadBtn.Size = new System.Drawing.Size(97, 38);
            this.reloadBtn.TabIndex = 1;
            this.reloadBtn.Text = "Reload";
            this.reloadBtn.UseVisualStyleBackColor = true;
            this.reloadBtn.Click += new System.EventHandler(this.reloadBtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(362, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 13);
            this.label8.TabIndex = 77;
            this.label8.Text = "To";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(154, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 76;
            this.label7.Text = "From";
            // 
            // toDatePicker
            // 
            this.toDatePicker.Location = new System.Drawing.Point(364, 40);
            this.toDatePicker.Name = "toDatePicker";
            this.toDatePicker.Size = new System.Drawing.Size(187, 20);
            this.toDatePicker.TabIndex = 74;
            // 
            // fromDatePicker
            // 
            this.fromDatePicker.Location = new System.Drawing.Point(157, 40);
            this.fromDatePicker.Name = "fromDatePicker";
            this.fromDatePicker.Size = new System.Drawing.Size(187, 20);
            this.fromDatePicker.TabIndex = 73;
            this.fromDatePicker.Value = new System.DateTime(2022, 11, 19, 0, 0, 0, 0);
            // 
            // filterBtn
            // 
            this.filterBtn.Location = new System.Drawing.Point(574, 40);
            this.filterBtn.Name = "filterBtn";
            this.filterBtn.Size = new System.Drawing.Size(43, 22);
            this.filterBtn.TabIndex = 78;
            this.filterBtn.Text = "Filter";
            this.filterBtn.UseVisualStyleBackColor = true;
            this.filterBtn.Click += new System.EventHandler(this.filterBtn_Click);
            // 
            // BestSellingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 818);
            this.Controls.Add(this.filterBtn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.toDatePicker);
            this.Controls.Add(this.fromDatePicker);
            this.Controls.Add(this.reloadBtn);
            this.Controls.Add(this.bestSellingDataGridView);
            this.Name = "BestSellingForm";
            this.Text = "BestSellingForm";
            this.Load += new System.EventHandler(this.BestSellingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bestSellingDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView bestSellingDataGridView;
        private System.Windows.Forms.Button reloadBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker toDatePicker;
        private System.Windows.Forms.DateTimePicker fromDatePicker;
        private System.Windows.Forms.Button filterBtn;
    }
}
