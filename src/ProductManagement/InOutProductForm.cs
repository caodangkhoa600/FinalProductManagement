using ProductManagement.Model;
using Services.OrderRowServices;
using Services.OrderServices;
using Services.ProductImportServices;
using Services.ProductServices;

namespace ProductManagement
{
    public partial class InOutProductForm : Form
    {
        private readonly IProductServices _productServices;
        private readonly IOrderService _orderService;
        private readonly IOrderRowService _orderRowService;
        private readonly IProductImportService _productImportService;
        public InOutProductForm(
            IProductServices productServices, 
            IOrderService orderService, 
            IOrderRowService orderRowService, 
            IProductImportService productImportService
            )
        {
            InitializeComponent();
            _productServices = productServices;
            _orderService = orderService;
            _orderRowService = orderRowService;
            _productImportService = productImportService;
        }

        private void loadData()
        {
            var productImported = _productImportService.GetAllProductImports();
            var products = _productServices.GetAllProducts().ToList();
            var data = new List<InOutProductModel>();
            var productImportedRows = productImported.GroupBy(p => p.ProductId)
                .Select(item =>
                new {
                    ProductId = item.Key,
                    Value = item.Select(x => x).ToList()
                });
            
            foreach (var productImportRecord in productImportedRows)
            {
                var product = products.First(p => p.Id == productImportRecord.ProductId);
                if (product == null)
                {
                    continue;
                }
                
                var quantity = productImportRecord.Value.Sum(p => p.Quantity);
                
                data.Add(new InOutProductModel
                {
                    ProductId = productImportRecord.ProductId,
                    Name = product.Name,
                    Price = product.Price,
                    Quantity = quantity,
                    TotalImport = quantity * product.Price
                });
            }
            
            if (data.Count > 0)
            {
                productDataGridView.DataSource = data;
            }
            else
            {
                MessageBox.Show("No Data");
            }
        }

        private void InOutProductForm_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void filterBtn_Click(object sender, EventArgs e)
        {
            string productName = filterTxtBox.Text;
            
            
            var products = _productServices
                .GetAllProducts()
                .Where(p => p.Name.ToLower().Contains(productName.ToLower()))
                .ToList();
            
            var productImported = _productImportService
                .GetAllProductImports()
                .Where(p => products.Select(i => i.Id).Contains(p.ProductId));
            
            var data = new List<InOutProductModel>();
            var productImportedRows = productImported.GroupBy(p => p.ProductId)
                .Select(item =>
                new {
                    ProductId = item.Key,
                    Value = item.Select(x => x).ToList()
                });
            
            foreach (var productImportRecord in productImportedRows)
            {
                var product = products.First(p => p.Id == productImportRecord.ProductId);
                if (product == null)
                {
                    continue;
                }
                
                var quantity = productImportRecord.Value.Sum(p => p.Quantity);
                
                data.Add(new InOutProductModel
                {
                    ProductId = productImportRecord.ProductId,
                    Name = product.Name,
                    Price = product.Price,
                    Quantity = quantity,
                    TotalImport = quantity * product.Price
                });
            }
            
            if (data.Count > 0)
            {
                productDataGridView.DataSource = data;
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
    }
}
