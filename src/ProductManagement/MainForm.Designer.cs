namespace ProductManagement
{
    partial class MainForm
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
            this.sideMenuPanel = new System.Windows.Forms.Panel();
            this.statisticSubPanel = new System.Windows.Forms.Panel();
            this.bestSellingProductBtn = new System.Windows.Forms.Button();
            this.monthlyIncomeBtn = new System.Windows.Forms.Button();
            this.inOutProductBtn = new System.Windows.Forms.Button();
            this.statisticBtn = new System.Windows.Forms.Button();
            this.ordersSubPanel = new System.Windows.Forms.Panel();
            this.printDeliverySlipBtn = new System.Windows.Forms.Button();
            this.updateStatusBtn = new System.Windows.Forms.Button();
            this.viewCustomerOrderBtn = new System.Windows.Forms.Button();
            this.viewAgentOrdersBtn = new System.Windows.Forms.Button();
            this.ordersBtn = new System.Windows.Forms.Button();
            this.productsSubPanel = new System.Windows.Forms.Panel();
            this.viewProductBtn = new System.Windows.Forms.Button();
            this.importProductBtn = new System.Windows.Forms.Button();
            this.updateProductBtn = new System.Windows.Forms.Button();
            this.createProductBtn = new System.Windows.Forms.Button();
            this.productsBtn = new System.Windows.Forms.Button();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.childFormPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.sideMenuPanel.SuspendLayout();
            this.statisticSubPanel.SuspendLayout();
            this.ordersSubPanel.SuspendLayout();
            this.productsSubPanel.SuspendLayout();
            this.childFormPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sideMenuPanel
            // 
            this.sideMenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.sideMenuPanel.Controls.Add(this.statisticSubPanel);
            this.sideMenuPanel.Controls.Add(this.statisticBtn);
            this.sideMenuPanel.Controls.Add(this.ordersSubPanel);
            this.sideMenuPanel.Controls.Add(this.ordersBtn);
            this.sideMenuPanel.Controls.Add(this.productsSubPanel);
            this.sideMenuPanel.Controls.Add(this.productsBtn);
            this.sideMenuPanel.Controls.Add(this.logoPanel);
            this.sideMenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.sideMenuPanel.Name = "sideMenuPanel";
            this.sideMenuPanel.Size = new System.Drawing.Size(250, 857);
            this.sideMenuPanel.TabIndex = 0;
            // 
            // statisticSubPanel
            // 
            this.statisticSubPanel.Controls.Add(this.bestSellingProductBtn);
            this.statisticSubPanel.Controls.Add(this.monthlyIncomeBtn);
            this.statisticSubPanel.Controls.Add(this.inOutProductBtn);
            this.statisticSubPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.statisticSubPanel.Location = new System.Drawing.Point(0, 549);
            this.statisticSubPanel.Name = "statisticSubPanel";
            this.statisticSubPanel.Size = new System.Drawing.Size(250, 124);
            this.statisticSubPanel.TabIndex = 6;
            // 
            // bestSellingProductBtn
            // 
            this.bestSellingProductBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.bestSellingProductBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.bestSellingProductBtn.FlatAppearance.BorderSize = 0;
            this.bestSellingProductBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bestSellingProductBtn.ForeColor = System.Drawing.Color.Silver;
            this.bestSellingProductBtn.Location = new System.Drawing.Point(0, 80);
            this.bestSellingProductBtn.Name = "bestSellingProductBtn";
            this.bestSellingProductBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.bestSellingProductBtn.Size = new System.Drawing.Size(250, 40);
            this.bestSellingProductBtn.TabIndex = 2;
            this.bestSellingProductBtn.Text = "Best-selling products";
            this.bestSellingProductBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bestSellingProductBtn.UseVisualStyleBackColor = false;
            this.bestSellingProductBtn.Click += new System.EventHandler(this.bestSellingProductBtn_Click);
            // 
            // monthlyIncomeBtn
            // 
            this.monthlyIncomeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.monthlyIncomeBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.monthlyIncomeBtn.FlatAppearance.BorderSize = 0;
            this.monthlyIncomeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.monthlyIncomeBtn.ForeColor = System.Drawing.Color.Silver;
            this.monthlyIncomeBtn.Location = new System.Drawing.Point(0, 40);
            this.monthlyIncomeBtn.Name = "monthlyIncomeBtn";
            this.monthlyIncomeBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.monthlyIncomeBtn.Size = new System.Drawing.Size(250, 40);
            this.monthlyIncomeBtn.TabIndex = 1;
            this.monthlyIncomeBtn.Text = "Monthly income";
            this.monthlyIncomeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.monthlyIncomeBtn.UseVisualStyleBackColor = false;
            this.monthlyIncomeBtn.Click += new System.EventHandler(this.monthlyIncomeBtn_Click);
            // 
            // inOutProductBtn
            // 
            this.inOutProductBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.inOutProductBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.inOutProductBtn.FlatAppearance.BorderSize = 0;
            this.inOutProductBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inOutProductBtn.ForeColor = System.Drawing.Color.Silver;
            this.inOutProductBtn.Location = new System.Drawing.Point(0, 0);
            this.inOutProductBtn.Name = "inOutProductBtn";
            this.inOutProductBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.inOutProductBtn.Size = new System.Drawing.Size(250, 40);
            this.inOutProductBtn.TabIndex = 0;
            this.inOutProductBtn.Text = "Incoming/Outgoing products";
            this.inOutProductBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inOutProductBtn.UseVisualStyleBackColor = false;
            this.inOutProductBtn.Click += new System.EventHandler(this.inOutProductBtn_Click);
            // 
            // statisticBtn
            // 
            this.statisticBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.statisticBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.statisticBtn.FlatAppearance.BorderSize = 0;
            this.statisticBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.statisticBtn.ForeColor = System.Drawing.Color.White;
            this.statisticBtn.Location = new System.Drawing.Point(0, 504);
            this.statisticBtn.Name = "statisticBtn";
            this.statisticBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.statisticBtn.Size = new System.Drawing.Size(250, 45);
            this.statisticBtn.TabIndex = 5;
            this.statisticBtn.Text = "Statistic";
            this.statisticBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.statisticBtn.UseVisualStyleBackColor = false;
            this.statisticBtn.Click += new System.EventHandler(this.statisticBtn_Click);
            // 
            // ordersSubPanel
            // 
            this.ordersSubPanel.Controls.Add(this.printDeliverySlipBtn);
            this.ordersSubPanel.Controls.Add(this.updateStatusBtn);
            this.ordersSubPanel.Controls.Add(this.viewCustomerOrderBtn);
            this.ordersSubPanel.Controls.Add(this.viewAgentOrdersBtn);
            this.ordersSubPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ordersSubPanel.Location = new System.Drawing.Point(0, 338);
            this.ordersSubPanel.Name = "ordersSubPanel";
            this.ordersSubPanel.Size = new System.Drawing.Size(250, 166);
            this.ordersSubPanel.TabIndex = 4;
            // 
            // printDeliverySlipBtn
            // 
            this.printDeliverySlipBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.printDeliverySlipBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.printDeliverySlipBtn.FlatAppearance.BorderSize = 0;
            this.printDeliverySlipBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printDeliverySlipBtn.ForeColor = System.Drawing.Color.Silver;
            this.printDeliverySlipBtn.Location = new System.Drawing.Point(0, 120);
            this.printDeliverySlipBtn.Name = "printDeliverySlipBtn";
            this.printDeliverySlipBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.printDeliverySlipBtn.Size = new System.Drawing.Size(250, 40);
            this.printDeliverySlipBtn.TabIndex = 4;
            this.printDeliverySlipBtn.Text = "Print delivery slip";
            this.printDeliverySlipBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.printDeliverySlipBtn.UseVisualStyleBackColor = false;
            this.printDeliverySlipBtn.Click += new System.EventHandler(this.printDeliverySlipBtn_Click);
            // 
            // updateStatusBtn
            // 
            this.updateStatusBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.updateStatusBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.updateStatusBtn.FlatAppearance.BorderSize = 0;
            this.updateStatusBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateStatusBtn.ForeColor = System.Drawing.Color.Silver;
            this.updateStatusBtn.Location = new System.Drawing.Point(0, 80);
            this.updateStatusBtn.Name = "updateStatusBtn";
            this.updateStatusBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.updateStatusBtn.Size = new System.Drawing.Size(250, 40);
            this.updateStatusBtn.TabIndex = 2;
            this.updateStatusBtn.Text = "Update status";
            this.updateStatusBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.updateStatusBtn.UseVisualStyleBackColor = false;
            this.updateStatusBtn.Click += new System.EventHandler(this.updateStatusBtn_Click);
            // 
            // viewCustomerOrderBtn
            // 
            this.viewCustomerOrderBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.viewCustomerOrderBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.viewCustomerOrderBtn.FlatAppearance.BorderSize = 0;
            this.viewCustomerOrderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewCustomerOrderBtn.ForeColor = System.Drawing.Color.Silver;
            this.viewCustomerOrderBtn.Location = new System.Drawing.Point(0, 40);
            this.viewCustomerOrderBtn.Name = "viewCustomerOrderBtn";
            this.viewCustomerOrderBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.viewCustomerOrderBtn.Size = new System.Drawing.Size(250, 40);
            this.viewCustomerOrderBtn.TabIndex = 1;
            this.viewCustomerOrderBtn.Text = "View customer orders list";
            this.viewCustomerOrderBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.viewCustomerOrderBtn.UseVisualStyleBackColor = false;
            this.viewCustomerOrderBtn.Click += new System.EventHandler(this.viewCustomerOrderBtn_Click);
            // 
            // viewAgentOrdersBtn
            // 
            this.viewAgentOrdersBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.viewAgentOrdersBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.viewAgentOrdersBtn.FlatAppearance.BorderSize = 0;
            this.viewAgentOrdersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewAgentOrdersBtn.ForeColor = System.Drawing.Color.Silver;
            this.viewAgentOrdersBtn.Location = new System.Drawing.Point(0, 0);
            this.viewAgentOrdersBtn.Name = "viewAgentOrdersBtn";
            this.viewAgentOrdersBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.viewAgentOrdersBtn.Size = new System.Drawing.Size(250, 40);
            this.viewAgentOrdersBtn.TabIndex = 0;
            this.viewAgentOrdersBtn.Text = "View agent orders list";
            this.viewAgentOrdersBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.viewAgentOrdersBtn.UseVisualStyleBackColor = false;
            this.viewAgentOrdersBtn.Click += new System.EventHandler(this.viewAgentOrdersBtn_Click);
            // 
            // ordersBtn
            // 
            this.ordersBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.ordersBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.ordersBtn.FlatAppearance.BorderSize = 0;
            this.ordersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ordersBtn.ForeColor = System.Drawing.Color.White;
            this.ordersBtn.Location = new System.Drawing.Point(0, 293);
            this.ordersBtn.Name = "ordersBtn";
            this.ordersBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ordersBtn.Size = new System.Drawing.Size(250, 45);
            this.ordersBtn.TabIndex = 3;
            this.ordersBtn.Text = "Orders";
            this.ordersBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ordersBtn.UseVisualStyleBackColor = false;
            this.ordersBtn.Click += new System.EventHandler(this.ordersBtn_Click);
            // 
            // productsSubPanel
            // 
            this.productsSubPanel.Controls.Add(this.viewProductBtn);
            this.productsSubPanel.Controls.Add(this.importProductBtn);
            this.productsSubPanel.Controls.Add(this.updateProductBtn);
            this.productsSubPanel.Controls.Add(this.createProductBtn);
            this.productsSubPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.productsSubPanel.Location = new System.Drawing.Point(0, 126);
            this.productsSubPanel.Name = "productsSubPanel";
            this.productsSubPanel.Size = new System.Drawing.Size(250, 167);
            this.productsSubPanel.TabIndex = 2;
            // 
            // viewProductBtn
            // 
            this.viewProductBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.viewProductBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.viewProductBtn.FlatAppearance.BorderSize = 0;
            this.viewProductBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewProductBtn.ForeColor = System.Drawing.Color.Silver;
            this.viewProductBtn.Location = new System.Drawing.Point(0, 120);
            this.viewProductBtn.Name = "viewProductBtn";
            this.viewProductBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.viewProductBtn.Size = new System.Drawing.Size(250, 44);
            this.viewProductBtn.TabIndex = 3;
            this.viewProductBtn.Text = "View product list";
            this.viewProductBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.viewProductBtn.UseVisualStyleBackColor = false;
            this.viewProductBtn.Click += new System.EventHandler(this.viewProductBtn_Click);
            // 
            // importProductBtn
            // 
            this.importProductBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.importProductBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.importProductBtn.FlatAppearance.BorderSize = 0;
            this.importProductBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.importProductBtn.ForeColor = System.Drawing.Color.Silver;
            this.importProductBtn.Location = new System.Drawing.Point(0, 80);
            this.importProductBtn.Name = "importProductBtn";
            this.importProductBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.importProductBtn.Size = new System.Drawing.Size(250, 40);
            this.importProductBtn.TabIndex = 2;
            this.importProductBtn.Text = "Import product";
            this.importProductBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.importProductBtn.UseVisualStyleBackColor = false;
            this.importProductBtn.Click += new System.EventHandler(this.importProductBtn_Click);
            // 
            // updateProductBtn
            // 
            this.updateProductBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.updateProductBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.updateProductBtn.FlatAppearance.BorderSize = 0;
            this.updateProductBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateProductBtn.ForeColor = System.Drawing.Color.Silver;
            this.updateProductBtn.Location = new System.Drawing.Point(0, 40);
            this.updateProductBtn.Name = "updateProductBtn";
            this.updateProductBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.updateProductBtn.Size = new System.Drawing.Size(250, 40);
            this.updateProductBtn.TabIndex = 1;
            this.updateProductBtn.Text = "Update product information";
            this.updateProductBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.updateProductBtn.UseVisualStyleBackColor = false;
            this.updateProductBtn.Click += new System.EventHandler(this.updateProductBtn_Click);
            // 
            // createProductBtn
            // 
            this.createProductBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.createProductBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.createProductBtn.FlatAppearance.BorderSize = 0;
            this.createProductBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createProductBtn.ForeColor = System.Drawing.Color.Silver;
            this.createProductBtn.Location = new System.Drawing.Point(0, 0);
            this.createProductBtn.Name = "createProductBtn";
            this.createProductBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.createProductBtn.Size = new System.Drawing.Size(250, 40);
            this.createProductBtn.TabIndex = 0;
            this.createProductBtn.Text = "Create new product";
            this.createProductBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.createProductBtn.UseVisualStyleBackColor = false;
            this.createProductBtn.Click += new System.EventHandler(this.createProductBtn_Click);
            // 
            // productsBtn
            // 
            this.productsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.productsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.productsBtn.FlatAppearance.BorderSize = 0;
            this.productsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productsBtn.ForeColor = System.Drawing.Color.White;
            this.productsBtn.Location = new System.Drawing.Point(0, 81);
            this.productsBtn.Name = "productsBtn";
            this.productsBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.productsBtn.Size = new System.Drawing.Size(250, 45);
            this.productsBtn.TabIndex = 1;
            this.productsBtn.Text = "Products";
            this.productsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.productsBtn.UseVisualStyleBackColor = false;
            this.productsBtn.Click += new System.EventHandler(this.productsBtn_Click);
            // 
            // logoPanel
            // 
            this.logoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoPanel.Location = new System.Drawing.Point(0, 0);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(250, 81);
            this.logoPanel.TabIndex = 0;
            // 
            // childFormPanel
            // 
            this.childFormPanel.Controls.Add(this.label1);
            this.childFormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.childFormPanel.Location = new System.Drawing.Point(250, 0);
            this.childFormPanel.Name = "childFormPanel";
            this.childFormPanel.Size = new System.Drawing.Size(1376, 857);
            this.childFormPanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(339, 352);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hello World";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1626, 857);
            this.Controls.Add(this.childFormPanel);
            this.Controls.Add(this.sideMenuPanel);
            this.Name = "MainForm";
            this.Text = "Product Management";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.sideMenuPanel.ResumeLayout(false);
            this.statisticSubPanel.ResumeLayout(false);
            this.ordersSubPanel.ResumeLayout(false);
            this.productsSubPanel.ResumeLayout(false);
            this.childFormPanel.ResumeLayout(false);
            this.childFormPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sideMenuPanel;
        private System.Windows.Forms.Panel productsSubPanel;
        private System.Windows.Forms.Button viewProductBtn;
        private System.Windows.Forms.Button importProductBtn;
        private System.Windows.Forms.Button updateProductBtn;
        private System.Windows.Forms.Button createProductBtn;
        private System.Windows.Forms.Button productsBtn;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.Panel ordersSubPanel;
        private System.Windows.Forms.Button updateStatusBtn;
        private System.Windows.Forms.Button viewCustomerOrderBtn;
        private System.Windows.Forms.Button viewAgentOrdersBtn;
        private System.Windows.Forms.Button ordersBtn;
        private System.Windows.Forms.Panel statisticSubPanel;
        private System.Windows.Forms.Button bestSellingProductBtn;
        private System.Windows.Forms.Button monthlyIncomeBtn;
        private System.Windows.Forms.Button inOutProductBtn;
        private System.Windows.Forms.Button statisticBtn;
        private System.Windows.Forms.Panel childFormPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button printDeliverySlipBtn;
    }
}

