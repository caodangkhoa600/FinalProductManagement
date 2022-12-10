﻿using Database.Entity;
using Services.ProductServices;

namespace ProductManagement
{
    public partial class CreateProductForm : Form
    {
        private readonly IProductService _productService;
        public CreateProductForm(IProductService productService)
        {
            _productService = productService;
            InitializeComponent();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            var name = nameTxtBox.Text;
            string priceString = priceTextBox.Text;
            
            int price;
            bool isNumeric = int.TryParse(priceString, out price);
            
            if (!isNumeric)
            {
                throw new Exception("Invalid price");
            }
        
            int quantity = (int)quantityNUD.Value;
        
            string id = System.Guid.NewGuid().ToString();
            string description = descriptionTxtBox.Text;
            string imageUrl = imageUrlTxtBox.Text;

            var product = new Product
            {
                Id = id,
                Name = name,
                Quantity = quantity,
                Price = price,
                Description = description,
                ImageUrl = imageUrl
            };

            _productService.AddProduct(product);
            MessageBox.Show("Create Successfully");
        }
    }
}
