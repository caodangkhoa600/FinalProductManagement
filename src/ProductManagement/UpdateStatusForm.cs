using Database.Entity;
using Services.OrderRowServices;
using Services.OrderServices;

namespace ProductManagement
{
    public partial class UpdateStatusForm : Form
    {
        private readonly IOrderService _orderService;
        private readonly IOrderRowService _orderRowService;
        public UpdateStatusForm(IOrderService orderService, IOrderRowService orderRowService)
        {
            _orderService = orderService;
            _orderRowService = orderRowService;
            InitializeComponent();
            paymentStatusComboBox.SelectedIndex = 0;
            paymentTypeComboBox.SelectedIndex = 0;
            orderStatusComboBox.SelectedIndex = 0;
        }

        private void loadData()
        {
            var orders = _orderService.GetAllOrders().ToList();
            
            if (orders.Count > 0)
            {
                orderDataGridView.DataSource = orders;
            }
            else
            {
                MessageBox.Show("No Data");
            }
        }

        private void UpdatePaymentStatusForm_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void orderDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = orderDataGridView.Rows[e.RowIndex];

                idTxtBox.Text = selectedRow.Cells["Id"].Value.ToString();
                paymentTypeTxtBox.Text = selectedRow.Cells["PaymentType"].Value.ToString();
                createdAtTxtBox.Text = selectedRow.Cells["CreatedAt"].Value.ToString();

                string[] orderStatus = { "Processing", "Delivering", "Delivered" };
                updateOrderStatusCB.SelectedIndex = Array.IndexOf(orderStatus, selectedRow.Cells["OrderStatus"].Value.ToString());

                string[] paymentTypes = { "Pending", "Paid" };
                updatePaymentStatusCB.SelectedIndex = Array.IndexOf(paymentTypes, selectedRow.Cells["PaymentStatus"].Value.ToString());
            }
        }

        private void filterBtn_Click(object sender, EventArgs e)
        {
            string filterId = filterOrderIdTxtBox.Text;
            
            if(filterId.Length > 0)
            {
                var data1 = _orderRowService.GetAllOrderRows().Where(e => e.OrderId == filterId).ToList();
                 
                if (data1.Count > 0)
                {
                    orderDataGridView.DataSource = data1;
                }
                else
                {
                    MessageBox.Show("No Data");
                }

                return;
            }

            var data = _orderService.GetAllOrders().ToList();
            string paymentType = paymentTypeComboBox.GetItemText(paymentTypeComboBox.SelectedItem);
            string paymentStatus = paymentStatusComboBox.GetItemText(paymentStatusComboBox.SelectedItem);
            string orderStatus = orderStatusComboBox.GetItemText(orderStatusComboBox.SelectedItem);
            DateTime fromDate = fromDatePicker.Value.Date;
            DateTime toDate = toDatePicker.Value.Date;
            bool isAnyDateChecked = anyDateCheckbox.Checked;
            
            if (paymentType != "Any")
            {
                data = data.Where(e => ((PaymentType) e.PaymentType).ToString().ToLower() == paymentType.ToLower()).ToList();
            }
            
            if (paymentStatus != "Any")
            {
                data = data.Where(e => ((PaymentStatus) e.PaymentStatus).ToString().ToLower() == paymentStatus.ToLower()).ToList();
            }
            
            if (orderStatus != "Any")
            {
                data = data.Where(e => ((OrderStatus)e.OrderStatus).ToString().ToLower() == orderStatus.ToLower()).ToList();
            }
            
            int compare = DateTime.Compare(fromDate, toDate);
            
            if (compare > 0)
            {
                MessageBox.Show("Invalid date range");
                return;
            }
            
            if (!isAnyDateChecked)
            {
                data = data.Where(e => DateTimeOffset.FromUnixTimeSeconds(e.CreatedAt.Value).DateTime >= fromDate && DateTimeOffset.FromUnixTimeSeconds(e.CreatedAt.Value).DateTime <= toDate).ToList();
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

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void resetFilterBtn_Click(object sender, EventArgs e)
        {
            filterOrderIdTxtBox.Text = "";
            paymentStatusComboBox.SelectedIndex = 0;
            paymentTypeComboBox.SelectedIndex = 0;
            orderStatusComboBox.SelectedIndex = 0;
            fromDatePicker.Value = DateTime.Today.Date;
            toDatePicker.Value = DateTime.Today.Date;
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            string orderId = idTxtBox.Text;
            string newPaymentStatus = updatePaymentStatusCB.GetItemText(updatePaymentStatusCB.SelectedItem);
            string newOrderStatus = updateOrderStatusCB.GetItemText(updateOrderStatusCB.SelectedItem);

            var order = _orderService.GetOrderByCode(orderId);
            order.PaymentStatus = (PaymentStatus) Enum.Parse(typeof(PaymentStatus), newPaymentStatus);
            order.OrderStatus = (OrderStatus) Enum.Parse(typeof(OrderStatus), newOrderStatus);
            _orderService.UpdateOrder(order);
            loadData();
            MessageBox.Show("Success");
        }
    }
}
