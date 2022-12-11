using Database.Entity;
using Microsoft.Extensions.DependencyInjection;
using Services.AccountService;
using Services.OrderServices;

namespace ProductManagement
{
    public partial class FindOrderForm : Form
    {
        private MainForm mainForm;
        private Button button;
        private readonly IOrderService _orderService;
        private readonly IAccountServices _accountServices;
        public FindOrderForm(IOrderService orderService, IAccountServices accountServices)
        {
            InitializeComponent();
            _orderService = orderService;
            _accountServices = accountServices;
        }

        public void Init(MainForm mainForm, Button button)
        {
            this.mainForm = mainForm;
            this.button = button;
        }

        private void findBtn_Click(object sender, EventArgs e)
        {
            string orderId = idTxtBox.Text;
            var orders = _orderService.GetAllOrders();
            var account = _accountServices.GetAllAccounts();

            var data = new List<string>();
            account.Where(a => a.Type == AccountType.Agent).ToList().ForEach(item =>
            {
                var order = orders.FirstOrDefault(o => o.Email == item.Email);
                if (order != null)
                {
                    data.Add(order.Id);
                }
            });
            
            if (data.Count > 0)
            {
                var form = Program.host.Services.GetRequiredService<PrintDeliverySlipForm>();
                form.Init(orderId);
                mainForm.openChildForm(form, button);
            }
            else
            {
                MessageBox.Show("No Data");
            }
        }
    }
}
