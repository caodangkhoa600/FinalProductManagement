namespace ProductManagement
{
    partial class CreateProductForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.quantityNUD = new System.Windows.Forms.NumericUpDown();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.createBtn = new System.Windows.Forms.Button();
            this.descriptionTxtBox = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.imageUrlTxtBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Price";
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Location = new System.Drawing.Point(179, 95);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.Size = new System.Drawing.Size(225, 20);
            this.nameTxtBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Quantity";
            // 
            // quantityNUD
            // 
            this.quantityNUD.Location = new System.Drawing.Point(179, 314);
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
            this.quantityNUD.Size = new System.Drawing.Size(73, 20);
            this.quantityNUD.TabIndex = 5;
            this.quantityNUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(179, 275);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 20);
            this.priceTextBox.TabIndex = 6;
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(524, 353);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(90, 49);
            this.createBtn.TabIndex = 7;
            this.createBtn.Text = "Create";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // descriptionTxtBox
            // 
            this.descriptionTxtBox.Location = new System.Drawing.Point(179, 163);
            this.descriptionTxtBox.Name = "descriptionTxtBox";
            this.descriptionTxtBox.Size = new System.Drawing.Size(435, 96);
            this.descriptionTxtBox.TabIndex = 47;
            this.descriptionTxtBox.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(81, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 46;
            this.label7.Text = "Description";
            // 
            // imageUrlTxtBox
            // 
            this.imageUrlTxtBox.Location = new System.Drawing.Point(179, 123);
            this.imageUrlTxtBox.Name = "imageUrlTxtBox";
            this.imageUrlTxtBox.Size = new System.Drawing.Size(435, 20);
            this.imageUrlTxtBox.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(81, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "Image URL";
            // 
            // CreateProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 721);
            this.Controls.Add(this.descriptionTxtBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.imageUrlTxtBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.quantityNUD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nameTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CreateProductForm";
            this.Text = "CreateProductForm";
            ((System.ComponentModel.ISupportInitialize)(this.quantityNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameTxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown quantityNUD;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.RichTextBox descriptionTxtBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox imageUrlTxtBox;
        private System.Windows.Forms.Label label6;
    }
}
