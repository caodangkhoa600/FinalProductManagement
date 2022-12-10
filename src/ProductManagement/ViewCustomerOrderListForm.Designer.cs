namespace ProductManagement
{
    partial class ViewCustomerOrderListForm
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
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.resetFilterBtn = new System.Windows.Forms.Button();
            this.anyDateCheckbox = new System.Windows.Forms.CheckBox();
            this.toDatePicker = new System.Windows.Forms.DateTimePicker();
            this.fromDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.orderStatusComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.paymentStatusComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.paymentTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.orderDetailsDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.filterBtn = new System.Windows.Forms.Button();
            this.filterNameTxtBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.orderDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(294, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 13);
            this.label8.TabIndex = 72;
            this.label8.Text = "To";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(86, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 71;
            this.label7.Text = "From";
            // 
            // resetFilterBtn
            // 
            this.resetFilterBtn.Location = new System.Drawing.Point(672, 65);
            this.resetFilterBtn.Name = "resetFilterBtn";
            this.resetFilterBtn.Size = new System.Drawing.Size(79, 22);
            this.resetFilterBtn.TabIndex = 70;
            this.resetFilterBtn.Text = "Reset filter";
            this.resetFilterBtn.UseVisualStyleBackColor = true;
            this.resetFilterBtn.Click += new System.EventHandler(this.resetFilterBtn_Click);
            // 
            // anyDateCheckbox
            // 
            this.anyDateCheckbox.AutoSize = true;
            this.anyDateCheckbox.Location = new System.Drawing.Point(494, 91);
            this.anyDateCheckbox.Name = "anyDateCheckbox";
            this.anyDateCheckbox.Size = new System.Drawing.Size(70, 17);
            this.anyDateCheckbox.TabIndex = 69;
            this.anyDateCheckbox.Text = "Any Date";
            this.anyDateCheckbox.UseVisualStyleBackColor = true;
            // 
            // toDatePicker
            // 
            this.toDatePicker.Location = new System.Drawing.Point(296, 88);
            this.toDatePicker.Name = "toDatePicker";
            this.toDatePicker.Size = new System.Drawing.Size(187, 20);
            this.toDatePicker.TabIndex = 68;
            // 
            // fromDatePicker
            // 
            this.fromDatePicker.Location = new System.Drawing.Point(89, 88);
            this.fromDatePicker.Name = "fromDatePicker";
            this.fromDatePicker.Size = new System.Drawing.Size(187, 20);
            this.fromDatePicker.TabIndex = 67;
            this.fromDatePicker.Value = new System.DateTime(2022, 11, 19, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(459, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 66;
            this.label6.Text = "Order status";
            // 
            // orderStatusComboBox
            // 
            this.orderStatusComboBox.FormattingEnabled = true;
            this.orderStatusComboBox.Items.AddRange(new object[] {
            "Any",
            "Processing",
            "Delivering",
            "Delivered"});
            this.orderStatusComboBox.Location = new System.Drawing.Point(462, 36);
            this.orderStatusComboBox.Name = "orderStatusComboBox";
            this.orderStatusComboBox.Size = new System.Drawing.Size(102, 21);
            this.orderStatusComboBox.TabIndex = 65;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(354, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 64;
            this.label4.Text = "Payment status";
            // 
            // paymentStatusComboBox
            // 
            this.paymentStatusComboBox.FormattingEnabled = true;
            this.paymentStatusComboBox.Items.AddRange(new object[] {
            "Any",
            "Pending",
            "Paid"});
            this.paymentStatusComboBox.Location = new System.Drawing.Point(354, 35);
            this.paymentStatusComboBox.Name = "paymentStatusComboBox";
            this.paymentStatusComboBox.Size = new System.Drawing.Size(102, 21);
            this.paymentStatusComboBox.TabIndex = 63;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(243, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 62;
            this.label3.Text = "Payment type";
            // 
            // paymentTypeComboBox
            // 
            this.paymentTypeComboBox.FormattingEnabled = true;
            this.paymentTypeComboBox.Items.AddRange(new object[] {
            "Any",
            "Bank",
            "Momo",
            "Cash"});
            this.paymentTypeComboBox.Location = new System.Drawing.Point(246, 35);
            this.paymentTypeComboBox.Name = "paymentTypeComboBox";
            this.paymentTypeComboBox.Size = new System.Drawing.Size(102, 21);
            this.paymentTypeComboBox.TabIndex = 61;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 428);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 60;
            this.label2.Text = "Order details";
            // 
            // orderDetailsDataGridView
            // 
            this.orderDetailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderDetailsDataGridView.Location = new System.Drawing.Point(89, 444);
            this.orderDetailsDataGridView.MultiSelect = false;
            this.orderDetailsDataGridView.Name = "orderDetailsDataGridView";
            this.orderDetailsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.orderDetailsDataGridView.Size = new System.Drawing.Size(943, 238);
            this.orderDetailsDataGridView.TabIndex = 59;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 58;
            this.label1.Text = "Customer orders";
            // 
            // filterBtn
            // 
            this.filterBtn.Location = new System.Drawing.Point(757, 65);
            this.filterBtn.Name = "filterBtn";
            this.filterBtn.Size = new System.Drawing.Size(43, 22);
            this.filterBtn.TabIndex = 57;
            this.filterBtn.Text = "Filter";
            this.filterBtn.UseVisualStyleBackColor = true;
            this.filterBtn.Click += new System.EventHandler(this.filterBtn_Click);
            // 
            // filterNameTxtBox
            // 
            this.filterNameTxtBox.Location = new System.Drawing.Point(89, 36);
            this.filterNameTxtBox.Name = "filterNameTxtBox";
            this.filterNameTxtBox.Size = new System.Drawing.Size(150, 20);
            this.filterNameTxtBox.TabIndex = 56;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(86, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 55;
            this.label5.Text = "Filter customer name";
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(607, 65);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(59, 22);
            this.refreshBtn.TabIndex = 54;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // orderDataGridView
            // 
            this.orderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderDataGridView.Location = new System.Drawing.Point(89, 177);
            this.orderDataGridView.MultiSelect = false;
            this.orderDataGridView.Name = "orderDataGridView";
            this.orderDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.orderDataGridView.Size = new System.Drawing.Size(943, 238);
            this.orderDataGridView.TabIndex = 53;
            this.orderDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.orderDataGridView_CellContentClick);
            // 
            // ViewCustomerOrderListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 818);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.resetFilterBtn);
            this.Controls.Add(this.anyDateCheckbox);
            this.Controls.Add(this.toDatePicker);
            this.Controls.Add(this.fromDatePicker);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.orderStatusComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.paymentStatusComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.paymentTypeComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.orderDetailsDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filterBtn);
            this.Controls.Add(this.filterNameTxtBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.orderDataGridView);
            this.Name = "ViewCustomerOrderListForm";
            this.Text = "ViewCustomerOrderListForm";
            this.Load += new System.EventHandler(this.ViewCustomerOrderListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button resetFilterBtn;
        private System.Windows.Forms.CheckBox anyDateCheckbox;
        private System.Windows.Forms.DateTimePicker toDatePicker;
        private System.Windows.Forms.DateTimePicker fromDatePicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox orderStatusComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox paymentStatusComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox paymentTypeComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView orderDetailsDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button filterBtn;
        private System.Windows.Forms.TextBox filterNameTxtBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.DataGridView orderDataGridView;
    }
}