using System;
using System.Windows.Forms;

namespace AdoNetDemo
{
    public partial class Form1 : Form
    {
        readonly ProductDal _productDal = new ProductDal();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void LoadProducts()
        {
            dgwproducts.DataSource = _productDal.GetAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _productDal.Add(new Product
            {
                UrunAdi = txtAd.Text,
                Stok = Convert.ToInt32(txtStok.Text),
                Fiyat = Convert.ToDecimal(txtFiyat.Text)

            });
            LoadProducts();
            MessageBox.Show(@"Ürün Eklendi");
        }

        private void dgwproducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgwproducts.CurrentRow.Cells[0].Value.ToString();
            txtIdDelete.Text = dgwproducts.CurrentRow.Cells[0].Value.ToString();
            txtUrunAdıUpdate.Text = dgwproducts.CurrentRow.Cells[1].Value.ToString();
            txtFiyatUpdate.Text = dgwproducts.CurrentRow.Cells[2].Value.ToString();
            txtStokUpdate.Text = dgwproducts.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnUptade_Click(object sender, EventArgs e)
        {
            Product product = new Product
            {
                Id = Convert.ToInt32(dgwproducts.CurrentRow.Cells[0].Value),
                UrunAdi = txtUrunAdıUpdate.Text,
                Fiyat = Convert.ToDecimal(txtFiyatUpdate.Text),
                Stok = Convert.ToInt32(txtStokUpdate.Text)
            };
            _productDal.Update(product);
            LoadProducts();
            MessageBox.Show("Güncellendi");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgwproducts.CurrentRow.Cells[0].Value);
            _productDal.Delete(id);
            LoadProducts();
            MessageBox.Show("Silindi");
        }
    }
}
