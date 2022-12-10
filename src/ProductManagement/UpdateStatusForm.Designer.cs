namespace ProductManagement
{
    partial class UpdateStatusForm
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
            this.filterBtn = new System.Windows.Forms.Button();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.orderDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.idTxtBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.paymentTypeTxtBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.createdAtTxtBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.updatePaymentStatusCB = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.updateBtn = new System.Windows.Forms.Button();
            this.filterOrderIdTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.updateOrderStatusCB = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.orderDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(239, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 13);
            this.label8.TabIndex = 72;
            this.label8.Text = "To";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 71;
            this.label7.Text = "From";
            // 
            // resetFilterBtn
            // 
            this.resetFilterBtn.Location = new System.Drawing.Point(824, 70);
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
            this.anyDateCheckbox.Location = new System.Drawing.Point(439, 98);
            this.anyDateCheckbox.Name = "anyDateCheckbox";
            this.anyDateCheckbox.Size = new System.Drawing.Size(70, 17);
            this.anyDateCheckbox.TabIndex = 69;
            this.anyDateCheckbox.Text = "Any Date";
            this.anyDateCheckbox.UseVisualStyleBackColor = true;
            // 
            // toDatePicker
            // 
            this.toDatePicker.Location = new System.Drawing.Point(241, 95);
            this.toDatePicker.Name = "toDatePicker";
            this.toDatePicker.Size = new System.Drawing.Size(187, 20);
            this.toDatePicker.TabIndex = 68;
            // 
            // fromDatePicker
            // 
            this.fromDatePicker.Location = new System.Drawing.Point(34, 95);
            this.fromDatePicker.Name = "fromDatePicker";
            this.fromDatePicker.Size = new System.Drawing.Size(187, 20);
            this.fromDatePicker.TabIndex = 67;
            this.fromDatePicker.Value = new System.DateTime(2022, 11, 19, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(455, 27);
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
            this.orderStatusComboBox.Location = new System.Drawing.Point(458, 43);
            this.orderStatusComboBox.Name = "orderStatusComboBox";
            this.orderStatusComboBox.Size = new System.Drawing.Size(102, 21);
            this.orderStatusComboBox.TabIndex = 65;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(350, 27);
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
            this.paymentStatusComboBox.Location = new System.Drawing.Point(350, 42);
            this.paymentStatusComboBox.Name = "paymentStatusComboBox";
            this.paymentStatusComboBox.Size = new System.Drawing.Size(102, 21);
            this.paymentStatusComboBox.TabIndex = 63;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(239, 27);
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
            this.paymentTypeComboBox.Location = new System.Drawing.Point(242, 42);
            this.paymentTypeComboBox.Name = "paymentTypeComboBox";
            this.paymentTypeComboBox.Size = new System.Drawing.Size(102, 21);
            this.paymentTypeComboBox.TabIndex = 61;
            // 
            // filterBtn
            // 
            this.filterBtn.Location = new System.Drawing.Point(909, 70);
            this.filterBtn.Name = "filterBtn";
            this.filterBtn.Size = new System.Drawing.Size(43, 22);
            this.filterBtn.TabIndex = 57;
            this.filterBtn.Text = "Filter";
            this.filterBtn.UseVisualStyleBackColor = true;
            this.filterBtn.Click += new System.EventHandler(this.filterBtn_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(759, 70);
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
            this.orderDataGridView.Location = new System.Drawing.Point(34, 164);
            this.orderDataGridView.MultiSelect = false;
            this.orderDataGridView.Name = "orderDataGridView";
            this.orderDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.orderDataGridView.Size = new System.Drawing.Size(943, 238);
            this.orderDataGridView.TabIndex = 53;
            this.orderDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.orderDataGridView_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 58;
            this.label1.Text = "Orders";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.filterOrderIdTxtBox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.resetFilterBtn);
            this.groupBox1.Controls.Add(this.anyDateCheckbox);
            this.groupBox1.Controls.Add(this.toDatePicker);
            this.groupBox1.Controls.Add(this.fromDatePicker);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.orderStatusComboBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.paymentStatusComboBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.paymentTypeComboBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.filterBtn);
            this.groupBox1.Controls.Add(this.refreshBtn);
            this.groupBox1.Controls.Add(this.orderDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(171, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1006, 420);
            this.groupBox1.TabIndex = 73;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter product";
            // 
            // idTxtBox
            // 
            this.idTxtBox.Enabled = false;
            this.idTxtBox.Location = new System.Drawing.Point(100, 28);
            this.idTxtBox.Name = "idTxtBox";
            this.idTxtBox.Size = new System.Drawing.Size(258, 20);
            this.idTxtBox.TabIndex = 79;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 78;
            this.label5.Text = "Order ID";
            // 
            // paymentTypeTxtBox
            // 
            this.paymentTypeTxtBox.Enabled = false;
            this.paymentTypeTxtBox.Location = new System.Drawing.Point(100, 63);
            this.paymentTypeTxtBox.Name = "paymentTypeTxtBox";
            this.paymentTypeTxtBox.Size = new System.Drawing.Size(92, 20);
            this.paymentTypeTxtBox.TabIndex = 86;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(14, 66);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 13);
            this.label12.TabIndex = 85;
            this.label12.Text = "Payment type";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(14, 103);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 13);
            this.label13.TabIndex = 87;
            this.label13.Text = "Order status";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(15, 173);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 13);
            this.label14.TabIndex = 89;
            this.label14.Text = "Payment status";
            // 
            // createdAtTxtBox
            // 
            this.createdAtTxtBox.Enabled = false;
            this.createdAtTxtBox.Location = new System.Drawing.Point(100, 136);
            this.createdAtTxtBox.Name = "createdAtTxtBox";
            this.createdAtTxtBox.Size = new System.Drawing.Size(191, 20);
            this.createdAtTxtBox.TabIndex = 92;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(14, 136);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 13);
            this.label15.TabIndex = 91;
            this.label15.Text = "Ordered at";
            // 
            // updatePaymentStatusCB
            // 
            this.updatePaymentStatusCB.FormattingEnabled = true;
            this.updatePaymentStatusCB.Items.AddRange(new object[] {
            "Pending",
            "Paid"});
            this.updatePaymentStatusCB.Location = new System.Drawing.Point(100, 170);
            this.updatePaymentStatusCB.Name = "updatePaymentStatusCB";
            this.updatePaymentStatusCB.Size = new System.Drawing.Size(121, 21);
            this.updatePaymentStatusCB.TabIndex = 93;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.updateOrderStatusCB);
            this.groupBox3.Controls.Add(this.updatePaymentStatusCB);
            this.groupBox3.Controls.Add(this.createdAtTxtBox);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.paymentTypeTxtBox);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.idTxtBox);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(484, 479);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(383, 208);
            this.groupBox3.TabIndex = 94;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Order info";
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(763, 713);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(104, 49);
            this.updateBtn.TabIndex = 95;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // filterOrderIdTxtBox
            // 
            this.filterOrderIdTxtBox.Location = new System.Drawing.Point(34, 42);
            this.filterOrderIdTxtBox.Name = "filterOrderIdTxtBox";
            this.filterOrderIdTxtBox.Size = new System.Drawing.Size(187, 20);
            this.filterOrderIdTxtBox.TabIndex = 73;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 74;
            this.label2.Text = "Order ID";
            // 
            // updateOrderStatusCB
            // 
            this.updateOrderStatusCB.FormattingEnabled = true;
            this.updateOrderStatusCB.Items.AddRange(new object[] {
            "Processing",
            "Delivering",
            "Delivered"});
            this.updateOrderStatusCB.Location = new System.Drawing.Point(100, 100);
            this.updateOrderStatusCB.Name = "updateOrderStatusCB";
            this.updateOrderStatusCB.Size = new System.Drawing.Size(121, 21);
            this.updateOrderStatusCB.TabIndex = 94;
            // 
            // UpdatePaymentStatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 818);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "UpdatePaymentStatusForm";
            this.Text = "UpdatePaymentStatusForm";
            this.Load += new System.EventHandler(this.UpdatePaymentStatusForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button filterBtn;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.DataGridView orderDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox idTxtBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox paymentTypeTxtBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox createdAtTxtBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox updatePaymentStatusCB;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox filterOrderIdTxtBox;
        private System.Windows.Forms.ComboBox updateOrderStatusCB;
    }
}