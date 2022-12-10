namespace ProductManagement
{
    partial class ImportProductForm
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
            this.updateBtn = new System.Windows.Forms.Button();
            this.priceTxtBox = new System.Windows.Forms.TextBox();
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.productDataGridView = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.idTxtBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.quantityNUD = new System.Windows.Forms.NumericUpDown();
            this.filterTxtBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.filterBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(442, 506);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(75, 49);
            this.updateBtn.TabIndex = 11;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // priceTxtBox
            // 
            this.priceTxtBox.Enabled = false;
            this.priceTxtBox.Location = new System.Drawing.Point(159, 460);
            this.priceTxtBox.Name = "priceTxtBox";
            this.priceTxtBox.Size = new System.Drawing.Size(100, 20);
            this.priceTxtBox.TabIndex = 10;
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Enabled = false;
            this.nameTxtBox.Location = new System.Drawing.Point(159, 424);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.Size = new System.Drawing.Size(258, 20);
            this.nameTxtBox.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 467);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 427);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Product name";
            // 
            // productDataGridView
            // 
            this.productDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDataGridView.Location = new System.Drawing.Point(67, 70);
            this.productDataGridView.MultiSelect = false;
            this.productDataGridView.Name = "productDataGridView";
            this.productDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productDataGridView.Size = new System.Drawing.Size(450, 286);
            this.productDataGridView.TabIndex = 6;
            this.productDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productDataGridView_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 389);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Product ID";
            // 
            // idTxtBox
            // 
            this.idTxtBox.Enabled = false;
            this.idTxtBox.Location = new System.Drawing.Point(159, 386);
            this.idTxtBox.Name = "idTxtBox";
            this.idTxtBox.Size = new System.Drawing.Size(258, 20);
            this.idTxtBox.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 506);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Import quantity";
            // 
            // quantityNUD
            // 
            this.quantityNUD.Location = new System.Drawing.Point(159, 499);
            this.quantityNUD.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.quantityNUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.quantityNUD.Name = "quantityNUD";
            this.quantityNUD.Size = new System.Drawing.Size(120, 20);
            this.quantityNUD.TabIndex = 15;
            this.quantityNUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // filterTxtBox
            // 
            this.filterTxtBox.Location = new System.Drawing.Point(167, 35);
            this.filterTxtBox.Name = "filterTxtBox";
            this.filterTxtBox.Size = new System.Drawing.Size(250, 20);
            this.filterTxtBox.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Filter product name";
            // 
            // filterBtn
            // 
            this.filterBtn.Location = new System.Drawing.Point(423, 35);
            this.filterBtn.Name = "filterBtn";
            this.filterBtn.Size = new System.Drawing.Size(43, 22);
            this.filterBtn.TabIndex = 18;
            this.filterBtn.Text = "Filter";
            this.filterBtn.UseVisualStyleBackColor = true;
            this.filterBtn.Click += new System.EventHandler(this.filterBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(474, 35);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(43, 22);
            this.resetBtn.TabIndex = 19;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // ImportProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 721);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.filterBtn);
            this.Controls.Add(this.filterTxtBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.quantityNUD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.idTxtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.priceTxtBox);
            this.Controls.Add(this.nameTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.productDataGridView);
            this.Name = "ImportProductForm";
            this.Text = "ImportProductForm";
            this.Load += new System.EventHandler(this.ImportProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.TextBox priceTxtBox;
        private System.Windows.Forms.TextBox nameTxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView productDataGridView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox idTxtBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown quantityNUD;
        private System.Windows.Forms.TextBox filterTxtBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button filterBtn;
        private System.Windows.Forms.Button resetBtn;
    }
}
