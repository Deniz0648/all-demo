using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;  // Access bağlantısı kurabilmek için.

namespace hasta2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        //Veri Tabanı Değişkenleri
        OleDbConnection con;
        OleDbDataAdapter da;
        OleDbCommand cmd;
        DataSet ds;


        //DataGridWiev de kayıtları listele
        void griddoldur()
        {
            con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=hasta2.accdb");
            da = new OleDbDataAdapter("Select *from hasta", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "hasta");
            dataGridView1.DataSource = ds.Tables["hasta"];
            con.Close();
        }


        //DataGridWiev de kayıtları Çağırma
        private void Form1_Load(object sender, EventArgs e)
        {
            griddoldur();
        }


        //ekleme
        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = "Insert into hasta (h_id,h_tc,h_ad,h_soyad,h_adres,h_tel,h_giris_tarihi,h_cikis_tarihi,h_teshis,h_ucret) values " + "(@no, @tc,@ad,@soyad,@adres,@tel,@giris,@cikis,@teshis,@ucret)";
            cmd = new OleDbCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@no", Convert.ToInt32(h_id.Text));
            cmd.Parameters.AddWithValue("@tc", h_tc.Text);
            cmd.Parameters.AddWithValue("@ad", h_ad.Text);
            cmd.Parameters.AddWithValue("@soyad", h_soyad.Text);
            cmd.Parameters.AddWithValue("@adres", h_adres.Text);
            cmd.Parameters.AddWithValue("@tel", h_tel.Text);
            cmd.Parameters.AddWithValue("@giris", h_giris_tarihi.Text);
            cmd.Parameters.AddWithValue("@cikis", h_cikis_tarihi.Text);
            cmd.Parameters.AddWithValue("@teshis", h_teshis.Text);
            cmd.Parameters.AddWithValue("@ucret", h_ucret.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            griddoldur();
        }


        //güncelleme
        private void button2_Click(object sender, EventArgs e)
        {
            string sorgu = "Update hasta Set h_tc=@tc, h_ad=@ad, h_soyad=@soyad, h_adres=@adres, h_tel=@tel, h_giris_tarihi=@giris, h_cikis_tarihi=@cikis, h_teshis=@teshis, h_ucret=@ucret Where h_id=@no";
            cmd = new OleDbCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@tc", h_tc.Text);
            cmd.Parameters.AddWithValue("@ad", h_ad.Text);
            cmd.Parameters.AddWithValue("@soyad", h_soyad.Text);
            cmd.Parameters.AddWithValue("@adres", h_adres.Text);
            cmd.Parameters.AddWithValue("@tel", h_tel.Text);
            cmd.Parameters.AddWithValue("@giris", h_giris_tarihi.Text);
            cmd.Parameters.AddWithValue("@cikis", h_cikis_tarihi.Text);
            cmd.Parameters.AddWithValue("@teshis", h_teshis.Text);
            cmd.Parameters.AddWithValue("@ucret", h_ucret.Text);
            cmd.Parameters.AddWithValue("@no", Convert.ToInt32(h_id.Text));
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            griddoldur();
        }


        //silme
        private void button3_Click(object sender, EventArgs e)
        {
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "delete from hasta where h_id=" + h_id.Text + "";
            cmd.ExecuteNonQuery();
            con.Close();
            griddoldur();
        }


        //DataGridWiev de Seçilen Satırı Textboxlara Aktarma
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e) 
        {
            h_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            h_tc.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            h_ad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            h_soyad.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            h_adres.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            h_tel.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            h_giris_tarihi.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            h_cikis_tarihi.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            h_teshis.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            h_ucret.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            
        }


        //Textbox'a Girilen İsmi DataGridWiev de Gösterme
        private void ara_TextChanged(object sender, EventArgs e)
        {
            con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=hasta2.accdb");
            da = new OleDbDataAdapter("SElect *from hasta where h_ad like '" + ara.Text + "%'", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "hasta");
            dataGridView1.DataSource = ds.Tables["hasta"];
            con.Close();
        }
    }
}
