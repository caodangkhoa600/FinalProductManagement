namespace ProductManagement
{
    partial class ViewAgentOrderListForm
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
            this.filterNameTxtBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.orderDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.orderDetailsDataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.paymentTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.paymentStatusComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.orderStatusComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.fromDatePicker = new System.Windows.Forms.DateTimePicker();
            this.toDatePicker = new System.Windows.Forms.DateTimePicker();
            this.anyDateCheckbox = new System.Windows.Forms.CheckBox();
            this.resetFilterBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.orderDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // filterBtn
            // 
            this.filterBtn.Location = new System.Drawing.Point(758, 65);
            this.filterBtn.Name = "filterBtn";
            this.filterBtn.Size = new System.Drawing.Size(43, 22);
            this.filterBtn.TabIndex = 37;
            this.filterBtn.Text = "Filter";
            this.filterBtn.UseVisualStyleBackColor = true;
            this.filterBtn.Click += new System.EventHandler(this.filterBtn_Click);
            // 
            // filterNameTxtBox
            // 
            this.filterNameTxtBox.Location = new System.Drawing.Point(90, 36);
            this.filterNameTxtBox.Name = "filterNameTxtBox";
            this.filterNameTxtBox.Size = new System.Drawing.Size(150, 20);
            this.filterNameTxtBox.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(87, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Filter agent name";
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(608, 65);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(59, 22);
            this.refreshBtn.TabIndex = 34;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // orderDataGridView
            // 
            this.orderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderDataGridView.Location = new System.Drawing.Point(90, 177);
            this.orderDataGridView.MultiSelect = false;
            this.orderDataGridView.Name = "orderDataGridView";
            this.orderDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.orderDataGridView.Size = new System.Drawing.Size(943, 238);
            this.orderDataGridView.TabIndex = 33;
            this.orderDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.orderDataGridView_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Agent orders";
            // 
            // orderDetailsDataGridView
            // 
            this.orderDetailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderDetailsDataGridView.Location = new System.Drawing.Point(90, 454);
            this.orderDetailsDataGridView.MultiSelect = false;
            this.orderDetailsDataGridView.Name = "orderDetailsDataGridView";
            this.orderDetailsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.orderDetailsDataGridView.Size = new System.Drawing.Size(943, 238);
            this.orderDetailsDataGridView.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 428);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Order details";
            // 
            // paymentTypeComboBox
            // 
            this.paymentTypeComboBox.FormattingEnabled = true;
            this.paymentTypeComboBox.Items.AddRange(new object[] {
            "Any",
            "Bank",
            "Momo",
            "Cash"});
            this.paymentTypeComboBox.Location = new System.Drawing.Point(247, 35);
            this.paymentTypeComboBox.Name = "paymentTypeComboBox";
            this.paymentTypeComboBox.Size = new System.Drawing.Size(102, 21);
            this.paymentTypeComboBox.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(244, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Payment type";
            // 
            // paymentStatusComboBox
            // 
            this.paymentStatusComboBox.FormattingEnabled = true;
            this.paymentStatusComboBox.Items.AddRange(new object[] {
            "Any",
            "Pending",
            "Paid"});
            this.paymentStatusComboBox.Location = new System.Drawing.Point(355, 35);
            this.paymentStatusComboBox.Name = "paymentStatusComboBox";
            this.paymentStatusComboBox.Size = new System.Drawing.Size(102, 21);
            this.paymentStatusComboBox.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(355, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "Payment status";
            // 
            // orderStatusComboBox
            // 
            this.orderStatusComboBox.FormattingEnabled = true;
            this.orderStatusComboBox.Items.AddRange(new object[] {
            "Any",
            "Processing",
            "Delivering",
            "Delivered"});
            this.orderStatusComboBox.Location = new System.Drawing.Point(463, 36);
            this.orderStatusComboBox.Name = "orderStatusComboBox";
            this.orderStatusComboBox.Size = new System.Drawing.Size(102, 21);
            this.orderStatusComboBox.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(460, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 46;
            this.label6.Text = "Order status";
            // 
            // fromDatePicker
            // 
            this.fromDatePicker.Location = new System.Drawing.Point(90, 88);
            this.fromDatePicker.Name = "fromDatePicker";
            this.fromDatePicker.Size = new System.Drawing.Size(187, 20);
            this.fromDatePicker.TabIndex = 47;
            this.fromDatePicker.Value = new System.DateTime(2022, 11, 19, 0, 0, 0, 0);
            // 
            // toDatePicker
            // 
            this.toDatePicker.Location = new System.Drawing.Point(297, 88);
            this.toDatePicker.Name = "toDatePicker";
            this.toDatePicker.Size = new System.Drawing.Size(187, 20);
            this.toDatePicker.TabIndex = 48;
            // 
            // anyDateCheckbox
            // 
            this.anyDateCheckbox.AutoSize = true;
            this.anyDateCheckbox.Location = new System.Drawing.Point(495, 91);
            this.anyDateCheckbox.Name = "anyDateCheckbox";
            this.anyDateCheckbox.Size = new System.Drawing.Size(70, 17);
            this.anyDateCheckbox.TabIndex = 49;
            this.anyDateCheckbox.Text = "Any Date";
            this.anyDateCheckbox.UseVisualStyleBackColor = true;
            // 
            // resetFilterBtn
            // 
            this.resetFilterBtn.Location = new System.Drawing.Point(673, 65);
            this.resetFilterBtn.Name = "resetFilterBtn";
            this.resetFilterBtn.Size = new System.Drawing.Size(79, 22);
            this.resetFilterBtn.TabIndex = 50;
            this.resetFilterBtn.Text = "Reset filter";
            this.resetFilterBtn.UseVisualStyleBackColor = true;
            this.resetFilterBtn.Click += new System.EventHandler(this.resetFilterBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(87, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 51;
            this.label7.Text = "From";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(295, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 13);
            this.label8.TabIndex = 52;
            this.label8.Text = "To";
            // 
            // ViewAgentOrderListForm
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
            this.Name = "ViewAgentOrderListForm";
            this.Text = "ViewOrderListForm";
            this.Load += new System.EventHandler(this.ViewOrderListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button filterBtn;
        private System.Windows.Forms.TextBox filterNameTxtBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.DataGridView orderDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView orderDetailsDataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox paymentTypeComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox paymentStatusComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox orderStatusComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker fromDatePicker;
        private System.Windows.Forms.DateTimePicker toDatePicker;
        private System.Windows.Forms.CheckBox anyDateCheckbox;
        private System.Windows.Forms.Button resetFilterBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}