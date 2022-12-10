using Services.ProductServices;

namespace ProductManagement
{
    public partial class ViewProductListForm : Form
    {
        private readonly IProductService _productService;
        public ViewProductListForm(IProductService productService)
        {
            _productService = productService;
            InitializeComponent();
        }

        private void loadData()
        {
            var data = _productService.GetAllProducts().ToList();
            if (data.Count > 0)
            {
                productDataGridView.DataSource = data;
            }
            else
            {
                MessageBox.Show("No Data");
            }
        }

        private void ViewProductListForm_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void productDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = productDataGridView.Rows[e.RowIndex];

                idTxtBox.Text = selectedRow.Cells["Id"].Value.ToString();
                nameTxtBox.Text = selectedRow.Cells["Name"].Value.ToString();
                priceTxtBox.Text = selectedRow.Cells["Price"].Value.ToString();
                quantityTxtBox.Text = selectedRow.Cells["Quantity"].Value.ToString();
                descriptionTxtBox.Text = selectedRow.Cells["Description"].Value.ToString();
                imageUrlTxtBox.Text = selectedRow.Cells["ImageUrl"].Value.ToString();
            }
        }

        private void filterBtn_Click(object sender, EventArgs e)
        {
            string filterName = filterTxtBox.Text;
            var data = _productService
                .GetAllProducts()
                .Where(p => p.Name.ToLower().Contains(filterName.ToLower()))
                .ToList();
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
