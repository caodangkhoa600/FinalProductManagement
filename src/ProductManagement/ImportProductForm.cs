using Services.ProductServices;

namespace ProductManagement
{
    public partial class ImportProductForm : Form
    {
        private DataGridViewRow _selectedRow = null;
        private readonly IProductService _productService;
        public ImportProductForm(IProductService productService)
        {
            _productService = productService;
            InitializeComponent();
        }

        private void loadData()
        {
            var products = _productService.GetAllProducts().ToList();
            
            if (products.Count > 0)
            {
                productDataGridView.DataSource = products;
            }
            else
            {
                MessageBox.Show("No Data");
            }
        }

        private void ImportProductForm_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void productDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                _selectedRow = productDataGridView.Rows[e.RowIndex];

                idTxtBox.Text = _selectedRow.Cells["Id"].Value.ToString();
                nameTxtBox.Text = _selectedRow.Cells["Name"].Value.ToString();
                priceTxtBox.Text = _selectedRow.Cells["Price"].Value.ToString();

            }
        }

        private void filterBtn_Click(object sender, EventArgs e)
        {
            string filterName = filterTxtBox.Text;

            var products = _productService
                .GetAllProducts()
                .Where(p => p.Name.ToLower().Contains(filterName.ToLower()))
                .ToList();
          
            if (products.Count > 0)
            {
                productDataGridView.DataSource = products;
            }
            else
            {
                MessageBox.Show("No Data");
            }
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
          
            if(_selectedRow == null)
            {
                throw new Exception("Please select a product");
            }
            
            string id = _selectedRow.Cells["Id"].Value.ToString();
            
            
            int importQuantity = (int) quantityNUD.Value;
            _productService.UpdateProductQuantity(id, importQuantity);
            MessageBox.Show("Success");
        }
    }
}
