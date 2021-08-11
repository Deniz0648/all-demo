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

namespace EntityOrnek
{
    public partial class Form1 : Form
    {

        DbSınavOgrenciEntities db = new DbSınavOgrenciEntities();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnderslistesi_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.tbl_Dersler.ToList();
            //SqlConnection baglanti = new SqlConnection(@"Data Source=MONSTER;Initial Catalog=DbSınavOgrenci;Integrated Security=True");
            //SqlCommand komut = new SqlCommand("Select*From tbl_Dersler", baglanti);
            //SqlDataAdapter da = new SqlDataAdapter(komut);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //dataGridView1.DataSource = dt;
        }

        private void btnogrlistele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.tbl_Ogrenci.ToList();
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
        }

        private void btnnotlistesi_Click(object sender, EventArgs e)
        {
            var query = from item in db.tbl_Notlar select new 
            { 
                item.NOTID, 
                item.tbl_Ogrenci.AD,
                item.tbl_Ogrenci.SOYAD,
                item.tbl_Dersler.DERSAD,
                item.SINAV1,
                item.SINAV2,
                item.SINAV3,
                item.ORT,
                item.DURUM
            };
            dataGridView1.DataSource = query.ToList();
            //dataGridView1.DataSource = db.tbl_Notlar.ToList();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            tbl_Ogrenci t = new tbl_Ogrenci();
            t.AD = TxtAD.Text;
            t.SOYAD = TxtSOYAD.Text;
            db.tbl_Ogrenci.Add(t);
            db.SaveChanges();
            dataGridView1.DataSource = db.tbl_Ogrenci.ToList();
            MessageBox.Show("Öğrenci Listeye Eklenmiştir!");

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(TxtOgrenciID.Text);
            var x = db.tbl_Ogrenci.Find(id);
            db.tbl_Ogrenci.Remove(x);
            db.SaveChanges();
            dataGridView1.DataSource = db.tbl_Ogrenci.ToList();
            MessageBox.Show("Öğrenci Listeden Silinmiştir!");
        }

        private void selectedRowsButton_Click(object sender, System.EventArgs e)
        {

        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(TxtOgrenciID.Text);
            var x = db.tbl_Ogrenci.Find(id);
            x.AD = TxtAD.Text;
            x.SOYAD = TxtSOYAD.Text;
            x.FOTOGRAF = TxtFOTO.Text;
            db.SaveChanges();
            dataGridView1.DataSource = db.tbl_Ogrenci.ToList();
            MessageBox.Show("Öğrenci Bilgileri Başarıyla Değişti!");
        }

        private void BtnProsedur_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.NOTLİSTESİ();
        }

        private void BtnBul_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.tbl_Ogrenci.Where(x => x.AD == TxtAD.Text | x.SOYAD == TxtSOYAD.Text).ToList();

        }

        private void TxtAD_TextChanged(object sender, EventArgs e)
        {
            string arama = TxtAD.Text;
            var degerler = from item in db.tbl_Ogrenci where item.AD.Contains(arama) select item;
            dataGridView1.DataSource = degerler.ToList();
        }

        private void TxtSOYAD_TextChanged(object sender, EventArgs e)
        {
            string arama = TxtSOYAD.Text;
            var degerler = from item in db.tbl_Ogrenci where item.SOYAD.Contains(arama) select item;
            dataGridView1.DataSource = degerler.ToList();
        }

        private void BtnLinqEntity_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked==true)
            {
                List<tbl_Ogrenci> liste1 = db.tbl_Ogrenci.OrderBy(p => p.AD).ToList();
                dataGridView1.DataSource = liste1;
                dataGridView1.Columns[3].Visible = false;
                dataGridView1.Columns[4].Visible = false;
            }
            if (radioButton2.Checked == true)
            {
                List<tbl_Ogrenci> liste2 = db.tbl_Ogrenci.OrderByDescending(p => p.AD).ToList();
                dataGridView1.DataSource = liste2;
                dataGridView1.Columns[3].Visible = false;
                dataGridView1.Columns[4].Visible = false;
            }
            if (radioButton3.Checked == true)
            {
                List<tbl_Ogrenci> liste3 = db.tbl_Ogrenci.Take(3).ToList();
                dataGridView1.DataSource = liste3;
                dataGridView1.Columns[3].Visible = false;
                dataGridView1.Columns[4].Visible = false;
            }
            if (radioButton4.Checked == true)
            {
                string harf = textBox1.Text;
                List<tbl_Ogrenci> liste4 = db.tbl_Ogrenci.Where(p => p.AD.StartsWith(harf)).ToList();
                dataGridView1.DataSource = liste4;
                dataGridView1.Columns[3].Visible = false;
                dataGridView1.Columns[4].Visible = false;
            }
            if (radioButton5.Checked == true)
            {
                string harf = textBox2.Text;
                List<tbl_Ogrenci> liste5 = db.tbl_Ogrenci.Where(p => p.AD.EndsWith(harf)).ToList();
                dataGridView1.DataSource = liste5;
                dataGridView1.Columns[3].Visible = false;
                dataGridView1.Columns[4].Visible = false;
            }
            if (radioButton6.Checked == true)
            {
                bool deger = db.tbl_Notlar.Any();
                MessageBox.Show(deger.ToString(),"Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            if (radioButton7.Checked == true)
            {
                int toplam = db.tbl_Ogrenci.Count();
                MessageBox.Show(toplam.ToString(), "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (radioButton8.Checked == true)
            {
                int ID = Convert.ToInt32(textBox3.Text);
                List<tbl_Ogrenci> liste6 = db.tbl_Ogrenci.Where(p => p.ID == ID).ToList();
                dataGridView1.DataSource = liste6;
                dataGridView1.Columns[3].Visible = false;
                dataGridView1.Columns[4].Visible = false;
            }
            if (radioButton9.Checked == true)
            {
                var toplam = db.tbl_Notlar.Sum(p=>p.SINAV1);
                MessageBox.Show(toplam.ToString(), "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (radioButton10.Checked == true)
            {
                var ORT = db.tbl_Notlar.Average(p => p.SINAV1);
                MessageBox.Show("1. Sınavın Ortalaması: "+ORT.ToString(), "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (radioButton11.Checked == true)
            {
                var ORT = db.tbl_Notlar.Average(p => p.SINAV1);
                List<tbl_Notlar> liste7 = db.tbl_Notlar.Where(p => p.SINAV1>=ORT).ToList();
                dataGridView1.DataSource = liste7;
                dataGridView1.Columns[8].Visible = false;
                dataGridView1.Columns[9].Visible = false;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            radioButton4.Checked=true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            radioButton5.Checked = true;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            radioButton8.Checked = true;
        }

        private void BtnJoin_Click(object sender, EventArgs e)
        {
            var sorgu = from d1 in db.tbl_Notlar
                        join d2 in db.tbl_Ogrenci
                        on d1.OGR equals d2.ID
                        join d3 in db.tbl_Dersler
                        on d1.DERS equals d3.DERSID

                        select new
                        {
                            ADI_SOYADI = d2.AD + " " + d2.SOYAD,
                            DERS = d3.DERSAD,
                            SINAV1 = d1.SINAV1,
                            SINAV2 = d1.SINAV2,
                            SINAV3 = d1.SINAV3,
                            ORTALAMA = d1.ORT,
                            DURUM = d1.DURUM
                        };
            dataGridView1.DataSource = sorgu.ToList();
                        
        }
    }
}
