using ProductManagement.Model;
using Services.OrderServices;

namespace ProductManagement
{
    public partial class MonthlyIncomeForm : Form
    {
        private readonly IOrderService _orderService;
        public MonthlyIncomeForm(IOrderService orderService)
        {
            _orderService = orderService;
            InitializeComponent();
        }

        private void MonthlyIncomeForm_Load(object sender, EventArgs e)
        {
            var data = new List<MonthlyIncomeModel>();
            var orders = _orderService.GetAllOrders()
                .ToList()
                .Select(x => new
                {
                    x.Address,
                    x.Email,
                    x.OrderStatus,
                    x.PaymentStatus,
                    x.PaymentType,
                    x.ShippingCost,
                    x.TotalPrice,
                    x.Id,
                    createdAt = DateTimeOffset.FromUnixTimeSeconds(x.CreatedAt.Value).DateTime,
                    x.UpdatedAt,
                })
                .OrderByDescending(e => e.createdAt)
                .GroupBy(
                    e => new
                    {
                        e.createdAt.Month,
                        e.createdAt.Year 
                    }
                ).Select(e => new
                {
                    Month = e.Key.Month,
                    Year = e.Key.Year,
                    Value = e.Select(x => x).ToList()
                });
            
            foreach (var item in orders)
            {
                data.Add(new MonthlyIncomeModel
                {
                    Year = item.Year,
                    Month = item.Month,
                    Income = item.Value.Sum(e => e.TotalPrice)
                });
            }


            // SqlConnection sc = new SqlConnection(MainForm.connectionString);
            //
            // sc.Open();
            // String sSQL = "select MONTH(o.createdAt) as month, YEAR(o.createdAt) as year, sum(totalPrice) as income from orders o " +
            //     "group by MONTH(o.createdAt), YEAR(o.createdAt) " +
            //     "order by max(o.createdAt) desc";
            //
            // SqlCommand cmd = new SqlCommand(sSQL, sc);
            // SqlDataAdapter da = new SqlDataAdapter(cmd);
            // DataTable dt = new DataTable();
            // da.Fill(dt);
            if (data.Count > 0)
            {
                incomeDataGridView.DataSource = data;
            }
            else
            {
                MessageBox.Show("No Data");
            }
            // sc.Close();
        }
    }
}
