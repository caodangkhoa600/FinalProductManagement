using Microsoft.Reporting.WinForms;
using ProductManagement.Model;
using Services.AccountServices;
using Services.OrderRowServices;
using Services.OrderServices;
using Services.ProductServices;

namespace ProductManagement
{
    public partial class PrintDeliverySlipForm : Form
    {
        private string _orderId;
        private readonly IAccountServices _accountServices;
        private readonly IOrderService _orderService;
        private readonly IOrderRowService _orderRowService;
        private readonly IProductService _productService;
        public PrintDeliverySlipForm(IAccountServices accountServices, IOrderService orderService, IOrderRowService orderRowService, IProductService productService)
        {
            _accountServices = accountServices;
            _orderService = orderService;
            _orderRowService = orderRowService;
            _productService = productService;
            InitializeComponent();
        }

        public void Init(string orderId)
        {
            this._orderId = orderId;
        }
        //
        private void PrintDeliverySlipForm_Load(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.DataSources.Clear();
            queryOrderRow(_orderId);
            queryOrder(_orderId);
        }

        private void queryOrder(string orderId)
        {
            var data = new List<PrintDeliverySlipModel>();
            var orders = _orderService.GetAllOrders().ToList();
            var accounts = _accountServices.GetAllAccounts();
            orders.ForEach(e =>
            {
                var account = accounts.First(a => a.Email == e.Email);
                data.Add(new PrintDeliverySlipModel
                {
                    Email = account.Email,
                    Name = account.Name,
                    Address = account.Address,
                    CreatedAt = DateTimeOffset.FromUnixTimeSeconds(e.CreatedAt.Value).DateTime,
                    TotalPrice = e.TotalPrice,
                    OrderId = e.Id
                });
            });
          
            ReportDataSource rds = new ReportDataSource("OrderInfo", data);
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }

        private void queryOrderRow(string orderId)
        {
            var orderRows = _orderRowService.GetAllOrderRows().ToList();
            var products = _productService.GetAllProducts();
            var data = new List<PrintDeliverySlipProductModel>();
            
            orderRows.ForEach(e =>
            {
                var product = products.First(p => p.Id == e.ProductId);
                data.Add(new PrintDeliverySlipProductModel
                {
                    Product = product.Name,
                    UnitPrice = product.Price,
                    Quantity = e.Quantity,
                    Subtotal = e.Quantity * product.Price
                });
            });
            
            ReportDataSource rds = new ReportDataSource("OrderRow", data);
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            
            this.reportViewer1.RefreshReport();
        }
    }
}
