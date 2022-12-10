using System.Configuration;

using Microsoft.Extensions.DependencyInjection;

namespace ProductManagement
{
    public partial class MainForm : Form
    {
        private Form currentActiveForm = null;
        private Button currentActiveButton = null;
        public static String connectionString = ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            productsSubPanel.Visible = false;
            ordersSubPanel.Visible = false;
            statisticSubPanel.Visible = false;
        }

        private void productsBtn_Click(object sender, EventArgs e)
        {
            productsSubPanel.Visible = !productsSubPanel.Visible;
            
        }

        private void ordersBtn_Click(object sender, EventArgs e)
        {
            ordersSubPanel.Visible = !ordersSubPanel.Visible;
        }

        private void statisticBtn_Click(object sender, EventArgs e)
        {
            statisticSubPanel.Visible = !statisticSubPanel.Visible;
        }

        public void openChildForm(Form form, Button button)
        {
            if (currentActiveForm != null) currentActiveForm.Close();
            if (currentActiveButton != null)
            {
                currentActiveButton.BackColor = Color.FromArgb(35, 32, 39);
            }

            currentActiveButton = button;
            currentActiveButton.BackColor = Color.FromArgb(20, 5, 50);

            currentActiveForm = form;
            currentActiveForm.TopLevel = false;
            currentActiveForm.FormBorderStyle = FormBorderStyle.None;
            currentActiveForm.Dock = DockStyle.Fill;
            childFormPanel.Controls.Add(currentActiveForm);
            childFormPanel.Tag = currentActiveForm;
            currentActiveForm.BringToFront();
            currentActiveForm.Show();
        }

        private void createProductBtn_Click(object sender, EventArgs e)
        {
            openChildForm(Program.host.Services.GetRequiredService<CreateProductForm>(), (Button) sender);
        }

        private void updateProductBtn_Click(object sender, EventArgs e)
        {
            openChildForm(Program.host.Services.GetRequiredService<UpdateProductForm>(), (Button) sender);
        }

        private void importProductBtn_Click(object sender, EventArgs e)
        {
            openChildForm(Program.host.Services.GetRequiredService<ImportProductForm>(), (Button)sender);
        }

        private void viewProductBtn_Click(object sender, EventArgs e)
        {
            openChildForm(Program.host.Services.GetRequiredService<ViewProductListForm>(), (Button)sender);
        }

        private void viewAgentOrdersBtn_Click(object sender, EventArgs e)
        {
            openChildForm(Program.host.Services.GetRequiredService<ViewAgentOrderListForm>(), (Button)sender);
        }

        private void viewCustomerOrderBtn_Click(object sender, EventArgs e)
        {
            openChildForm(Program.host.Services.GetRequiredService<ViewCustomerOrderListForm>(), (Button)sender);
        }

        private void updateStatusBtn_Click(object sender, EventArgs e)
        {
            openChildForm(Program.host.Services.GetRequiredService<UpdateStatusForm>(), (Button)sender);
        }

        private void printDeliverySlipBtn_Click(object sender, EventArgs e)
        {
            var findOrderForm = Program.host.Services.GetRequiredService<FindOrderForm>();
            findOrderForm.Init(this, (Button) sender);
            openChildForm(findOrderForm, (Button)sender);
        }

        private void inOutProductBtn_Click(object sender, EventArgs e)
        {
            openChildForm(Program.host.Services.GetRequiredService<InOutProductForm>(), (Button)sender);
        }

        private void monthlyIncomeBtn_Click(object sender, EventArgs e)
        {
            openChildForm(Program.host.Services.GetRequiredService<MonthlyIncomeForm>(), (Button)sender);
        }

        private void bestSellingProductBtn_Click(object sender, EventArgs e)
        {
            openChildForm(Program.host.Services.GetRequiredService<BestSellingForm>(), (Button)sender);
        }
    }
}
