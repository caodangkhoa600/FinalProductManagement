namespace ProductManagement
{
    partial class ViewProductListForm
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
            this.idTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.priceTxtBox = new System.Windows.Forms.TextBox();
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.productDataGridView = new System.Windows.Forms.DataGridView();
            this.quantityTxtBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.imageUrlTxtBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.descriptionTxtBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // filterBtn
            // 
            this.filterBtn.Location = new System.Drawing.Point(402, 37);
            this.filterBtn.Name = "filterBtn";
            this.filterBtn.Size = new System.Drawing.Size(43, 22);
            this.filterBtn.TabIndex = 32;
            this.filterBtn.Text = "Filter";
            this.filterBtn.UseVisualStyleBackColor = true;
            this.filterBtn.Click += new System.EventHandler(this.filterBtn_Click);
            // 
            // filterTxtBox
            // 
            this.filterTxtBox.Location = new System.Drawing.Point(160, 39);
            this.filterTxtBox.Name = "filterTxtBox";
            this.filterTxtBox.Size = new System.Drawing.Size(228, 20);
            this.filterTxtBox.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Filter product name";
            // 
            // idTxtBox
            // 
            this.idTxtBox.Enabled = false;
            this.idTxtBox.Location = new System.Drawing.Point(152, 390);
            this.idTxtBox.Name = "idTxtBox";
            this.idTxtBox.Size = new System.Drawing.Size(358, 20);
            this.idTxtBox.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 393);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Product ID";
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(451, 37);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(59, 22);
            this.refreshBtn.TabIndex = 25;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // priceTxtBox
            // 
            this.priceTxtBox.Enabled = false;
            this.priceTxtBox.Location = new System.Drawing.Point(152, 600);
            this.priceTxtBox.Name = "priceTxtBox";
            this.priceTxtBox.Size = new System.Drawing.Size(100, 20);
            this.priceTxtBox.TabIndex = 24;
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Enabled = false;
            this.nameTxtBox.Location = new System.Drawing.Point(152, 428);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.Size = new System.Drawing.Size(358, 20);
            this.nameTxtBox.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 607);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 431);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Product name";
            // 
            // productDataGridView
            // 
            this.productDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDataGridView.Location = new System.Drawing.Point(60, 74);
            this.productDataGridView.MultiSelect = false;
            this.productDataGridView.Name = "productDataGridView";
            this.productDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productDataGridView.Size = new System.Drawing.Size(450, 286);
            this.productDataGridView.TabIndex = 20;
            this.productDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productDataGridView_CellContentClick);
            // 
            // quantityTxtBox
            // 
            this.quantityTxtBox.Enabled = false;
            this.quantityTxtBox.Location = new System.Drawing.Point(152, 636);
            this.quantityTxtBox.Name = "quantityTxtBox";
            this.quantityTxtBox.Size = new System.Drawing.Size(100, 20);
            this.quantityTxtBox.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 643);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Quantity";
            // 
            // imageUrlTxtBox
            // 
            this.imageUrlTxtBox.Enabled = false;
            this.imageUrlTxtBox.Location = new System.Drawing.Point(152, 463);
            this.imageUrlTxtBox.Name = "imageUrlTxtBox";
            this.imageUrlTxtBox.Size = new System.Drawing.Size(358, 20);
            this.imageUrlTxtBox.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 470);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Image URL";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(57, 505);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 38;
            this.label7.Text = "Description";
            // 
            // descriptionTxtBox
            // 
            this.descriptionTxtBox.Enabled = false;
            this.descriptionTxtBox.Location = new System.Drawing.Point(152, 493);
            this.descriptionTxtBox.Name = "descriptionTxtBox";
            this.descriptionTxtBox.Size = new System.Drawing.Size(358, 96);
            this.descriptionTxtBox.TabIndex = 39;
            this.descriptionTxtBox.Text = "";
            // 
            // ViewProductListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 682);
            this.Controls.Add(this.descriptionTxtBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.imageUrlTxtBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.quantityTxtBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.filterBtn);
            this.Controls.Add(this.filterTxtBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.idTxtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.priceTxtBox);
            this.Controls.Add(this.nameTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.productDataGridView);
            this.Name = "ViewProductListForm";
            this.Text = "ViewProductListForm";
            this.Load += new System.EventHandler(this.ViewProductListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button filterBtn;
        private System.Windows.Forms.TextBox filterTxtBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox idTxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.TextBox priceTxtBox;
        private System.Windows.Forms.TextBox nameTxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView productDataGridView;
        private System.Windows.Forms.TextBox quantityTxtBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox imageUrlTxtBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox descriptionTxtBox;
    }
}