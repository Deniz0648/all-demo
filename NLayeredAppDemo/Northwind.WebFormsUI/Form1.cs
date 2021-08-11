using System;
using System.Windows.Forms;
using Northwind.Business.Abstract;
using Northwind.Business.Concrete;
using Northwind.DataAccess.Concrete.EntityFramework;
using NorthWind.Entities.Concrete;

namespace Northwind.WebFormsUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _productService = new ProductManager(new EfProductDal());
            _categoryService = new CategoryManager(new EfCategoryDal());
        }

        private IProductService _productService;
        private ICategoryService _categoryService;

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
            LoadCategories();
        }

        private void LoadCategories()
        {
            cbxCategory.DataSource = _categoryService.GetAll();
            cbxCategory.DisplayMember = "CategoryName";
            cbxCategory.ValueMember = "CategoryId";

            cbxCategoryIdAdd.DataSource = _categoryService.GetAll();
            cbxCategoryIdAdd.DisplayMember = "CategoryName";
            cbxCategoryIdAdd.ValueMember = "CategoryId";

            cbxCategoryIdUpp.DataSource = _categoryService.GetAll();
            cbxCategoryIdUpp.DisplayMember = "CategoryName";
            cbxCategoryIdUpp.ValueMember = "CategoryId";
        }

        private void LoadProducts()
        {
            dgwProduct.DataSource = _productService.GetAll();
        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgwProduct.DataSource = _productService.GetProductByCategory(Convert.ToInt32(cbxCategory.SelectedValue));
            }
            catch
            {

            }

        }

        private void tbxProductName_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxProductName.Text))
            {
                LoadProducts();
            }
            else
            {
                dgwProduct.DataSource = _productService.GetProductsByProductName(tbxProductName.Text);
            }

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            _productService.Add(new Product
            {
                CategoryId = Convert.ToInt32(cbxCategoryIdAdd.SelectedValue),
                ProductName = TbxProductNameAdd.Text,
                UnitPrice = Convert.ToDecimal(tbxUnitPriceAdd.Text),
                QuantityPerUnit = tbxQuantityPerUnitAdd.Text,
                UnitsInStock = Convert.ToInt16(tbxUnitsInStockAdd.Text)
            });
            MessageBox.Show("Ürün Kaydedildi!");
            LoadProducts();
        }

        private void btnUpp_Click(object sender, EventArgs e)
        {
            _productService.Update(new Product
            {
                ProductId = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value),
                CategoryId = Convert.ToInt32(cbxCategoryIdUpp.SelectedValue),
                ProductName = tbxProductNameUpp.Text,
                UnitPrice = Convert.ToDecimal(tbxUnitPriceUpp.Text),
                QuantityPerUnit = tbxQuantityPerUnitUpp.Text,
                UnitsInStock = Convert.ToInt16(tbxUnitsInStockUpp.Text)
            });
            MessageBox.Show("Ürün Güncellendi!");
            LoadProducts();
        }

        private void dgwProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgwProduct.CurrentRow;
            tbxProductNameUpp.Text = dgwProduct.CurrentRow.Cells[1].Value.ToString();
            cbxCategoryIdUpp.SelectedValue = dgwProduct.CurrentRow.Cells[2].Value;
            tbxUnitPriceUpp.Text= dgwProduct.CurrentRow.Cells[3].Value.ToString();
            tbxQuantityPerUnitUpp.Text=dgwProduct.CurrentRow.Cells[4].Value.ToString();
            tbxUnitsInStockUpp.Text=dgwProduct.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _productService.Delete(new Product
            {
                ProductId=Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value)
                });
            MessageBox.Show("Ürün Silindi!");
            LoadProducts();
        }
    }
}