namespace ProductManagement
{
    partial class InOutProductForm
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
            this.filterBtn = new System.Windows.Forms.Button();
            this.filterTxtBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.productDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // filterBtn
            // 
            this.filterBtn.Location = new System.Drawing.Point(499, 64);
            this.filterBtn.Name = "filterBtn";
            this.filterBtn.Size = new System.Drawing.Size(43, 22);
            this.filterBtn.TabIndex = 37;
            this.filterBtn.Text = "Filter";
            this.filterBtn.UseVisualStyleBackColor = true;
            this.filterBtn.Click += new System.EventHandler(this.filterBtn_Click);
            // 
            // filterTxtBox
            // 
            this.filterTxtBox.Location = new System.Drawing.Point(257, 66);
            this.filterTxtBox.Name = "filterTxtBox";
            this.filterTxtBox.Size = new System.Drawing.Size(228, 20);
            this.filterTxtBox.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(154, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Filter product name";
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(548, 64);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(59, 22);
            this.refreshBtn.TabIndex = 34;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // productDataGridView
            // 
            this.productDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDataGridView.Location = new System.Drawing.Point(157, 101);
            this.productDataGridView.MultiSelect = false;
            this.productDataGridView.Name = "productDataGridView";
            this.productDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productDataGridView.Size = new System.Drawing.Size(948, 408);
            this.productDataGridView.TabIndex = 33;
            // 
            // InOutProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 818);
            this.Controls.Add(this.filterBtn);
            this.Controls.Add(this.filterTxtBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.productDataGridView);
            this.Name = "InOutProductForm";
            this.Text = "InOutProductForm";
            this.Load += new System.EventHandler(this.InOutProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button filterBtn;
        private System.Windows.Forms.TextBox filterTxtBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.DataGridView productDataGridView;
    }
}
