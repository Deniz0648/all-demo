using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EntityFrameWorkDemo
{
    public partial class Form1 : Form
    {
        private ProductDal _productDal = new ProductDal();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadMethod();
        }

        private void LoadMethod()
        {
            dgwproducts.DataSource = _productDal.GetAll();
        }

        //private void SearchMethod(string key)
        //{
        //    dgwproducts.DataSource = _productDal.GetAll().Where(p => p.UrunAdi.ToLower.Contains(key.ToLower)).ToList();
        //}

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _productDal.Add(new Product
            {
                UrunAdi = txtAd.Text,
                Fiyat = Convert.ToDecimal(txtFiyat.Text),
                Stok = Convert.ToInt32(txtStok.Text)
            });
            LoadMethod();
            MessageBox.Show("Eklendi!");
        }

        private void btnUptade_Click(object sender, EventArgs e)
        {
            _productDal.Update(new Product
            {
                Id = Convert.ToInt32(dgwproducts.CurrentRow.Cells[0].Value),
                UrunAdi = txtUrunAdıUpdate.Text,
                Fiyat = Convert.ToDecimal(txtFiyatUpdate.Text),
                Stok = Convert.ToInt32(txtStokUpdate.Text)
            });
            LoadMethod();
            MessageBox.Show("Güncellendi!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _productDal.Delete(new Product
            {
                Id = Convert.ToInt32(dgwproducts.CurrentRow.Cells[0].Value)
            });
            LoadMethod();
            MessageBox.Show("Silindi!");
        }

        private void dgwproducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgwproducts.CurrentRow.Cells[0].Value.ToString();
            txtIdDelete.Text = dgwproducts.CurrentRow.Cells[0].Value.ToString();
            txtUrunAdıUpdate.Text = dgwproducts.CurrentRow.Cells[1].Value.ToString();
            txtFiyatUpdate.Text = dgwproducts.CurrentRow.Cells[2].Value.ToString();
            txtStokUpdate.Text = dgwproducts.CurrentRow.Cells[3].Value.ToString();
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            //SearchMethod(txtAra.Text);
            dgwproducts.DataSource = _productDal.GetByName(txtAra.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _productDal.GetById(1);
        }
    }
}
