
using Services.ProductServices;

namespace ProductManagement
{
    public partial class UpdateProductForm : Form {

        private DataGridViewRow _selectedRow = null;
        private readonly IProductServices _productServices;
    
        public UpdateProductForm(IProductServices productServices)
        {
            _productServices = productServices;
            InitializeComponent();
        }

        private void loadData()
        {
            var data = _productServices.GetAllProducts().ToList();
            if (data.Count > 0)
            {
                productDataGridView.DataSource = data;
            }
            else
            {
                MessageBox.Show("No Data");
            }
        }

        private void UpdateProductForm_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            // SqlConnection sc = new SqlConnection(MainForm.connectionString);
            // try
            // {
            //     sc.Open();
            //
            string name = nameTxtBox.Text;
            string priceString = priceTxtBox.Text;
            string description = descriptionTxtBox.Text;
            string imageUrl = imageUrlTxtBox.Text;
            
            int price;
            bool isNumeric = int.TryParse(priceString, out price);
            
            if (!isNumeric)
            {
                throw new Exception("Invalid price");
            }
            
            string id = _selectedRow.Cells["productId"].Value.ToString();

            var product = _productServices.GetProductById(id);
            product.Name = name;
            product.Price = price;
            product.Description = description;
            product.ImageUrl = imageUrl;
            _productServices.UpdateProduct(product);
           
            loadData();
            
            MessageBox.Show("Success");
          
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                _selectedRow = productDataGridView.Rows[e.RowIndex];

                nameTxtBox.Text = _selectedRow.Cells["name"].Value.ToString();
                priceTxtBox.Text = _selectedRow.Cells["price"].Value.ToString();
                descriptionTxtBox.Text = _selectedRow.Cells["description"].Value.ToString();
                imageUrlTxtBox.Text = _selectedRow.Cells["imageUrl"].Value.ToString();
            }
        }
    }
}
