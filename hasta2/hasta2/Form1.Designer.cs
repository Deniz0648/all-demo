
namespace hasta2
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.h_id = new System.Windows.Forms.TextBox();
            this.h_tc = new System.Windows.Forms.TextBox();
            this.h_ad = new System.Windows.Forms.TextBox();
            this.h_soyad = new System.Windows.Forms.TextBox();
            this.h_adres = new System.Windows.Forms.TextBox();
            this.h_tel = new System.Windows.Forms.TextBox();
            this.h_giris_tarihi = new System.Windows.Forms.TextBox();
            this.h_cikis_tarihi = new System.Windows.Forms.TextBox();
            this.h_teshis = new System.Windows.Forms.TextBox();
            this.h_ucret = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.ara = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1045, 186);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hasta Numarası";
            // 
            // h_id
            // 
            this.h_id.Location = new System.Drawing.Point(16, 250);
            this.h_id.Name = "h_id";
            this.h_id.Size = new System.Drawing.Size(100, 20);
            this.h_id.TabIndex = 2;
            // 
            // h_tc
            // 
            this.h_tc.Location = new System.Drawing.Point(123, 250);
            this.h_tc.Name = "h_tc";
            this.h_tc.Size = new System.Drawing.Size(100, 20);
            this.h_tc.TabIndex = 3;
            // 
            // h_ad
            // 
            this.h_ad.Location = new System.Drawing.Point(230, 250);
            this.h_ad.Name = "h_ad";
            this.h_ad.Size = new System.Drawing.Size(100, 20);
            this.h_ad.TabIndex = 4;
            // 
            // h_soyad
            // 
            this.h_soyad.Location = new System.Drawing.Point(337, 250);
            this.h_soyad.Name = "h_soyad";
            this.h_soyad.Size = new System.Drawing.Size(100, 20);
            this.h_soyad.TabIndex = 5;
            // 
            // h_adres
            // 
            this.h_adres.Location = new System.Drawing.Point(444, 250);
            this.h_adres.Name = "h_adres";
            this.h_adres.Size = new System.Drawing.Size(100, 20);
            this.h_adres.TabIndex = 6;
            // 
            // h_tel
            // 
            this.h_tel.Location = new System.Drawing.Point(551, 250);
            this.h_tel.Name = "h_tel";
            this.h_tel.Size = new System.Drawing.Size(100, 20);
            this.h_tel.TabIndex = 7;
            // 
            // h_giris_tarihi
            // 
            this.h_giris_tarihi.Location = new System.Drawing.Point(658, 250);
            this.h_giris_tarihi.Name = "h_giris_tarihi";
            this.h_giris_tarihi.Size = new System.Drawing.Size(100, 20);
            this.h_giris_tarihi.TabIndex = 8;
            // 
            // h_cikis_tarihi
            // 
            this.h_cikis_tarihi.Location = new System.Drawing.Point(765, 250);
            this.h_cikis_tarihi.Name = "h_cikis_tarihi";
            this.h_cikis_tarihi.Size = new System.Drawing.Size(100, 20);
            this.h_cikis_tarihi.TabIndex = 9;
            // 
            // h_teshis
            // 
            this.h_teshis.Location = new System.Drawing.Point(872, 250);
            this.h_teshis.Name = "h_teshis";
            this.h_teshis.Size = new System.Drawing.Size(100, 20);
            this.h_teshis.TabIndex = 10;
            // 
            // h_ucret
            // 
            this.h_ucret.Location = new System.Drawing.Point(979, 250);
            this.h_ucret.Name = "h_ucret";
            this.h_ucret.Size = new System.Drawing.Size(100, 20);
            this.h_ucret.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Hasta TC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(252, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Hasta Adı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(355, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Hasta Soyadı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(464, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Hasta Adres";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(574, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Hasta Tel";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(668, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Hasta Giriş Tarihi";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(776, 234);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Hasta Çıkış Tarihi";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(905, 234);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Teşhiş";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1012, 234);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Üçret";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 287);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(230, 287);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 22;
            this.button2.Text = "Güncelle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(444, 287);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 23);
            this.button3.TabIndex = 23;
            this.button3.Text = "Sil";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(668, 292);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "İsme Göre Ara";
            // 
            // ara
            // 
            this.ara.Location = new System.Drawing.Point(872, 289);
            this.ara.Name = "ara";
            this.ara.Size = new System.Drawing.Size(100, 20);
            this.ara.TabIndex = 25;
            this.ara.TextChanged += new System.EventHandler(this.ara_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 401);
            this.Controls.Add(this.ara);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.h_ucret);
            this.Controls.Add(this.h_teshis);
            this.Controls.Add(this.h_cikis_tarihi);
            this.Controls.Add(this.h_giris_tarihi);
            this.Controls.Add(this.h_tel);
            this.Controls.Add(this.h_adres);
            this.Controls.Add(this.h_soyad);
            this.Controls.Add(this.h_ad);
            this.Controls.Add(this.h_tc);
            this.Controls.Add(this.h_id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox h_id;
        private System.Windows.Forms.TextBox h_tc;
        private System.Windows.Forms.TextBox h_ad;
        private System.Windows.Forms.TextBox h_soyad;
        private System.Windows.Forms.TextBox h_adres;
        private System.Windows.Forms.TextBox h_tel;
        private System.Windows.Forms.TextBox h_giris_tarihi;
        private System.Windows.Forms.TextBox h_cikis_tarihi;
        private System.Windows.Forms.TextBox h_teshis;
        private System.Windows.Forms.TextBox h_ucret;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox ara;
    }
}

