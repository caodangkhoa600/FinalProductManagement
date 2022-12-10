using Database.Entity;
using ProductManagement.Model;
using Repositories.AccountRepositories;
using Repositories.OrderRepositories;
using Repositories.ProductRepositories;
using Repository.OrderRowRepositories;

namespace ProductManagement
{
    public partial class ViewCustomerOrderListForm : Form
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IAccountRepository _accountRepository;
        private readonly IProductRepository _productRepository;
        private readonly IOrderRowRepository _orderRowRepository;
        public ViewCustomerOrderListForm(
            IOrderRepository orderRepository, 
            IProductRepository productRepository, 
            IOrderRowRepository orderRowRepository, 
            IAccountRepository accountRepository)
        {
            _orderRepository = orderRepository;
            _productRepository = productRepository;
            _orderRowRepository = orderRowRepository;
            _accountRepository = accountRepository;
            InitializeComponent();
            paymentStatusComboBox.SelectedIndex = 0;
            paymentTypeComboBox.SelectedIndex = 0;
            orderStatusComboBox.SelectedIndex = 0;
        }

        private void loadData()
        {
            var accounts = _accountRepository.GetAllAccounts();
            var orders = _orderRepository.GetAllOrders();
            var data = new List<CustomerOrderFullModel>();
            orders.ToList().ForEach(e =>
            {
                var account = accounts.First(a => a.Email == e.Email);
                if (account.Type == AccountType.Customer)
                {
                    data.Add(new CustomerOrderFullModel
                    {
                        OrderId = e.Id,
                        Email = e.Email,
                        FullName = account.Name,
                        Address = account.Address,
                        PaymentType = ((PaymentType)e.PaymentType).ToString(),
                        PaymentStatus = ((PaymentStatus) e.PaymentStatus).ToString(),
                        OrderStatus = ((OrderStatus) e.OrderStatus).ToString(),
                        TotalPrice = e.TotalPrice,
                        CreatedAt = DateTimeOffset.FromUnixTimeSeconds(e.CreatedAt.Value).Date 
                    });
                }
            });
           
            if (data.Count > 0)
            {
                orderDataGridView.DataSource = data;
            }
            else
            {
                MessageBox.Show("No Data");
            }
        }

        private void ViewCustomerOrderListForm_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void orderDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = orderDataGridView.Rows[e.RowIndex];
            
                string orderId = selectedRow.Cells["Id"].Value.ToString();

                var products = _productRepository.GetAllProducts();
                var orderRows = _orderRowRepository.GetAllOrderRows().Where(e => e.OrderId == orderId);
                
                var data = new List<CustomerOrderModel>();
                orderRows.ToList().ForEach(e =>
                {
                    var product = products.First(p => p.Id == e.ProductId);
                    data.Add(new CustomerOrderModel
                    {
                        OrderId = orderId,
                        ProductId = product.Id,
                        ProductName = product.Name,
                        Quantity = e.Quantity,
                        Price = product.Price,
                        Total = e.Quantity * product.Price
                    });
                });
                if (data.Count > 0)
                {
                    orderDetailsDataGridView.DataSource = data;
                }
                else
                {
                    MessageBox.Show("No Data");
                }
            }
        }

        private void filterBtn_Click(object sender, EventArgs e)
        {
            string filterName = filterNameTxtBox.Text;
            
            string paymentType = paymentTypeComboBox.GetItemText(paymentTypeComboBox.SelectedItem);
            string paymentStatus = paymentStatusComboBox.GetItemText(paymentStatusComboBox.SelectedItem);
            string orderStatus = orderStatusComboBox.GetItemText(orderStatusComboBox.SelectedItem);
            DateTime fromDate = fromDatePicker.Value.Date;
            DateTime toDate = toDatePicker.Value.Date;
            bool isAnyDateChecked = anyDateCheckbox.Checked;
            
            var accounts = _accountRepository.GetAllAccounts();
            var orders = _orderRepository.GetAllOrders();
            var data = new List<CustomerOrderFullModel>();
            orders.ToList().ForEach(e =>
            {
               var account = accounts.First(a => a.Email == e.Email); 
               if (account.Type == AccountType.Customer)
               {
                   data.Add(new CustomerOrderFullModel
                   {
                       OrderId = e.Id,
                       Email = e.Email,
                       FullName = account.Name,
                       Address = account.Address,
                       PaymentType = ((PaymentType)e.PaymentType).ToString(),
                       PaymentStatus = ((PaymentStatus) e.PaymentStatus).ToString(),
                       OrderStatus = ((OrderStatus) e.OrderStatus).ToString(),
                       TotalPrice = e.TotalPrice,
                       CreatedAt = DateTimeOffset.FromUnixTimeSeconds(e.CreatedAt.Value).Date 
                   });
               }
            }); 
          
            if (filterName.Trim().Length > 0)
            {
                data = data.Where(e => e.FullName.ToLower().Contains(filterName.ToLower())).ToList();
            }
            
            if (paymentType != "Any")
            {
                data = data.Where(e => e.PaymentType.ToLower() == paymentType.ToLower()).ToList();
            }
            
            if (paymentStatus != "Any")
            {
                data = data.Where(e => e.PaymentStatus.ToLower() == paymentStatus.ToLower()).ToList();
            }
            
            if (orderStatus != "Any")
            {
                data = data.Where(e => e.OrderStatus.ToLower() == orderStatus.ToLower()).ToList();
            }
            
            int compare = DateTime.Compare(fromDate, toDate);
            
            if (compare > 0)
            {
                MessageBox.Show("Invalid date range");
                return;
            }
            
            if (!isAnyDateChecked)
            {
                data = data.Where(e => e.CreatedAt >= fromDate && e.CreatedAt <= toDate).ToList();
            }
         
            if (data.Count > 0)
            {
                orderDataGridView.DataSource = data;
            }
            else
            {
                MessageBox.Show("No Data");
            }
            
        }

        private void resetFilterBtn_Click(object sender, EventArgs e)
        {
            filterNameTxtBox.Text = "";
            paymentStatusComboBox.SelectedIndex = 0;
            paymentTypeComboBox.SelectedIndex = 0;
            orderStatusComboBox.SelectedIndex = 0;
            fromDatePicker.Value = DateTime.Today.Date;
            toDatePicker.Value = DateTime.Today.Date;
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
