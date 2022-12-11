using ProductManagement.Model;
using Services.OrderRowServices;
using Services.OrderServices;
using Services.ProductServices;

namespace ProductManagement
{
    public partial class BestSellingForm : Form
    {
        private readonly IOrderService _orderService;
        private readonly IProductServices _productServices;
        private readonly IOrderRowService _orderRowService;
        public BestSellingForm(IOrderService orderService, IProductServices productServices, IOrderRowService orderRowService)
        {
            _orderService = orderService;
            _productServices = productServices;
            _orderRowService = orderRowService;
            InitializeComponent();
            fromDatePicker.Format = DateTimePickerFormat.Custom;
            fromDatePicker.CustomFormat = "MM/yyyy";
            toDatePicker.Format = DateTimePickerFormat.Custom;
            toDatePicker.CustomFormat = "MM/yyyy";
        }

        private void loadData()
        {
            var orders = _orderService.GetAllOrders();
            var products = _productServices.GetAllProducts();
            var orderRows = _orderRowService.GetAllOrderRows();

            HashSet<string> checkedProduct = new HashSet<string>();

            var data = new List<BestSellingModel>();
            
            
            orderRows.ToList().ForEach(e =>
            {
                if (checkedProduct.Add(e.ProductId))
                {
                    var p = products.First(p => p.Id == e.ProductId);
                    var quantity = products.Where(x => x.Id == e.ProductId).Sum(x => x.Quantity);
                    data.Add(new BestSellingModel()
                    {
                        ProductId = e.ProductId,
                        ProductName = p.Name,
                        Quantity = quantity,
                        Profit = p.Price * quantity,
                    });
                }
            });
            if (data.Count > 0)
            {
                bestSellingDataGridView.DataSource = data;
            }
            else
            {
                MessageBox.Show("No data");
            }

          
        }

        private void BestSellingForm_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void reloadBtn_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void filterBtn_Click(object sender, EventArgs e)
        {
            DateTime fromDate = fromDatePicker.Value.Date;
            DateTime toDate = toDatePicker.Value.Date;
            int compare = DateTime.Compare(fromDate, toDate);
            
            if (compare > 0)
            {
                MessageBox.Show("Invalid date range");
                return;
            }
            
            var products = _productServices.GetAllProducts();
            var orderRows = _orderRowService.GetAllOrderRows();

            HashSet<string> checkedProduct = new HashSet<string>();

            var data = new List<BestSellingModel>();
            
            
            orderRows.Where(e => e.CreatedAt >= new DateTimeOffset(fromDate).ToUnixTimeSeconds() && e.CreatedAt <= new DateTimeOffset(toDate).ToUnixTimeSeconds()).ToList().ForEach(e =>
            {
                if (checkedProduct.Add(e.ProductId))
                {
                    var p = products.First(p => p.Id == e.ProductId);
                    var quantity = products.Where(x => x.Id == e.ProductId).Sum(x => x.Quantity);
                    data.Add(new BestSellingModel()
                    {
                        ProductId = e.ProductId,
                        ProductName = p.Name,
                        Quantity = quantity,
                        Profit = p.Price * quantity,
                    });
                }
            });
            
            if (data.Count > 0)
            {
                bestSellingDataGridView.DataSource = data;
            }
            else
            {
                MessageBox.Show("No data");
            }
            
        }
    }
}
