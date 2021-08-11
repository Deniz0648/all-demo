
namespace EntityFrameWorkDemo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtIdDelete = new System.Windows.Forms.TextBox();
            this.lblUrunIdDelete = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.grxUpdate = new System.Windows.Forms.GroupBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.btnUptade = new System.Windows.Forms.Button();
            this.txtUrunAdıUpdate = new System.Windows.Forms.TextBox();
            this.lblNameUpdate = new System.Windows.Forms.Label();
            this.lblFiyatUpdate = new System.Windows.Forms.Label();
            this.txtStokUpdate = new System.Windows.Forms.TextBox();
            this.txtFiyatUpdate = new System.Windows.Forms.TextBox();
            this.lblStokUpdate = new System.Windows.Forms.Label();
            this.gbxAdd = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.fiyat = new System.Windows.Forms.Label();
            this.txtStok = new System.Windows.Forms.TextBox();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.stok = new System.Windows.Forms.Label();
            this.dgwproducts = new System.Windows.Forms.DataGridView();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.lblAra = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.grxUpdate.SuspendLayout();
            this.gbxAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwproducts)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtIdDelete);
            this.groupBox1.Controls.Add(this.lblUrunIdDelete);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Location = new System.Drawing.Point(374, 168);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(175, 187);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Update a product";
            // 
            // txtIdDelete
            // 
            this.txtIdDelete.Location = new System.Drawing.Point(69, 14);
            this.txtIdDelete.Name = "txtIdDelete";
            this.txtIdDelete.ReadOnly = true;
            this.txtIdDelete.Size = new System.Drawing.Size(100, 20);
            this.txtIdDelete.TabIndex = 9;
            // 
            // lblUrunIdDelete
            // 
            this.lblUrunIdDelete.AutoSize = true;
            this.lblUrunIdDelete.Location = new System.Drawing.Point(15, 17);
            this.lblUrunIdDelete.Name = "lblUrunIdDelete";
            this.lblUrunIdDelete.Size = new System.Drawing.Size(44, 13);
            this.lblUrunIdDelete.TabIndex = 8;
            this.lblUrunIdDelete.Text = "Urun ID";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(69, 40);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // grxUpdate
            // 
            this.grxUpdate.Controls.Add(this.txtId);
            this.grxUpdate.Controls.Add(this.lblId);
            this.grxUpdate.Controls.Add(this.btnUptade);
            this.grxUpdate.Controls.Add(this.txtUrunAdıUpdate);
            this.grxUpdate.Controls.Add(this.lblNameUpdate);
            this.grxUpdate.Controls.Add(this.lblFiyatUpdate);
            this.grxUpdate.Controls.Add(this.txtStokUpdate);
            this.grxUpdate.Controls.Add(this.txtFiyatUpdate);
            this.grxUpdate.Controls.Add(this.lblStokUpdate);
            this.grxUpdate.Location = new System.Drawing.Point(193, 168);
            this.grxUpdate.Name = "grxUpdate";
            this.grxUpdate.Size = new System.Drawing.Size(175, 187);
            this.grxUpdate.TabIndex = 14;
            this.grxUpdate.TabStop = false;
            this.grxUpdate.Text = "Update a product";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(69, 14);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 9;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(15, 17);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(44, 13);
            this.lblId.TabIndex = 8;
            this.lblId.Text = "Urun ID";
            // 
            // btnUptade
            // 
            this.btnUptade.Location = new System.Drawing.Point(69, 118);
            this.btnUptade.Name = "btnUptade";
            this.btnUptade.Size = new System.Drawing.Size(100, 23);
            this.btnUptade.TabIndex = 7;
            this.btnUptade.Text = "Güncelle";
            this.btnUptade.UseVisualStyleBackColor = true;
            this.btnUptade.Click += new System.EventHandler(this.btnUptade_Click);
            // 
            // txtUrunAdıUpdate
            // 
            this.txtUrunAdıUpdate.Location = new System.Drawing.Point(69, 40);
            this.txtUrunAdıUpdate.Name = "txtUrunAdıUpdate";
            this.txtUrunAdıUpdate.Size = new System.Drawing.Size(100, 20);
            this.txtUrunAdıUpdate.TabIndex = 2;
            // 
            // lblNameUpdate
            // 
            this.lblNameUpdate.AutoSize = true;
            this.lblNameUpdate.Location = new System.Drawing.Point(11, 43);
            this.lblNameUpdate.Name = "lblNameUpdate";
            this.lblNameUpdate.Size = new System.Drawing.Size(48, 13);
            this.lblNameUpdate.TabIndex = 1;
            this.lblNameUpdate.Text = "Urun Adı";
            // 
            // lblFiyatUpdate
            // 
            this.lblFiyatUpdate.AutoSize = true;
            this.lblFiyatUpdate.Location = new System.Drawing.Point(30, 69);
            this.lblFiyatUpdate.Name = "lblFiyatUpdate";
            this.lblFiyatUpdate.Size = new System.Drawing.Size(29, 13);
            this.lblFiyatUpdate.TabIndex = 3;
            this.lblFiyatUpdate.Text = "Fiyat";
            // 
            // txtStokUpdate
            // 
            this.txtStokUpdate.Location = new System.Drawing.Point(69, 92);
            this.txtStokUpdate.Name = "txtStokUpdate";
            this.txtStokUpdate.Size = new System.Drawing.Size(100, 20);
            this.txtStokUpdate.TabIndex = 6;
            // 
            // txtFiyatUpdate
            // 
            this.txtFiyatUpdate.Location = new System.Drawing.Point(69, 66);
            this.txtFiyatUpdate.Name = "txtFiyatUpdate";
            this.txtFiyatUpdate.Size = new System.Drawing.Size(100, 20);
            this.txtFiyatUpdate.TabIndex = 4;
            // 
            // lblStokUpdate
            // 
            this.lblStokUpdate.AutoSize = true;
            this.lblStokUpdate.Location = new System.Drawing.Point(30, 95);
            this.lblStokUpdate.Name = "lblStokUpdate";
            this.lblStokUpdate.Size = new System.Drawing.Size(29, 13);
            this.lblStokUpdate.TabIndex = 5;
            this.lblStokUpdate.Text = "Stok";
            // 
            // gbxAdd
            // 
            this.gbxAdd.Controls.Add(this.btnAdd);
            this.gbxAdd.Controls.Add(this.txtAd);
            this.gbxAdd.Controls.Add(this.lblName);
            this.gbxAdd.Controls.Add(this.fiyat);
            this.gbxAdd.Controls.Add(this.txtStok);
            this.gbxAdd.Controls.Add(this.txtFiyat);
            this.gbxAdd.Controls.Add(this.stok);
            this.gbxAdd.Location = new System.Drawing.Point(12, 168);
            this.gbxAdd.Name = "gbxAdd";
            this.gbxAdd.Size = new System.Drawing.Size(175, 187);
            this.gbxAdd.TabIndex = 13;
            this.gbxAdd.TabStop = false;
            this.gbxAdd.Text = "Add a product";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(69, 97);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(69, 19);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 20);
            this.txtAd.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(15, 22);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(48, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Urun Adı";
            // 
            // fiyat
            // 
            this.fiyat.AutoSize = true;
            this.fiyat.Location = new System.Drawing.Point(34, 48);
            this.fiyat.Name = "fiyat";
            this.fiyat.Size = new System.Drawing.Size(29, 13);
            this.fiyat.TabIndex = 3;
            this.fiyat.Text = "Fiyat";
            // 
            // txtStok
            // 
            this.txtStok.Location = new System.Drawing.Point(69, 71);
            this.txtStok.Name = "txtStok";
            this.txtStok.Size = new System.Drawing.Size(100, 20);
            this.txtStok.TabIndex = 6;
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(69, 45);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(100, 20);
            this.txtFiyat.TabIndex = 4;
            // 
            // stok
            // 
            this.stok.AutoSize = true;
            this.stok.Location = new System.Drawing.Point(34, 74);
            this.stok.Name = "stok";
            this.stok.Size = new System.Drawing.Size(29, 13);
            this.stok.TabIndex = 5;
            this.stok.Text = "Stok";
            // 
            // dgwproducts
            // 
            this.dgwproducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwproducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwproducts.Location = new System.Drawing.Point(12, 12);
            this.dgwproducts.Name = "dgwproducts";
            this.dgwproducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwproducts.Size = new System.Drawing.Size(687, 150);
            this.dgwproducts.TabIndex = 12;
            this.dgwproducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwproducts_CellClick);
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(593, 182);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(103, 20);
            this.txtAra.TabIndex = 16;
            this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged);
            // 
            // lblAra
            // 
            this.lblAra.AutoSize = true;
            this.lblAra.Location = new System.Drawing.Point(564, 185);
            this.lblAra.Name = "lblAra";
            this.lblAra.Size = new System.Drawing.Size(23, 13);
            this.lblAra.TabIndex = 17;
            this.lblAra.Text = "Ara";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(591, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "ID ye Göre Ara";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 365);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblAra);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grxUpdate);
            this.Controls.Add(this.gbxAdd);
            this.Controls.Add(this.dgwproducts);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grxUpdate.ResumeLayout(false);
            this.grxUpdate.PerformLayout();
            this.gbxAdd.ResumeLayout(false);
            this.gbxAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwproducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtIdDelete;
        private System.Windows.Forms.Label lblUrunIdDelete;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox grxUpdate;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnUptade;
        private System.Windows.Forms.TextBox txtUrunAdıUpdate;
        private System.Windows.Forms.Label lblNameUpdate;
        private System.Windows.Forms.Label lblFiyatUpdate;
        private System.Windows.Forms.TextBox txtStokUpdate;
        private System.Windows.Forms.TextBox txtFiyatUpdate;
        private System.Windows.Forms.Label lblStokUpdate;
        private System.Windows.Forms.GroupBox gbxAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label fiyat;
        private System.Windows.Forms.TextBox txtStok;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.Label stok;
        private System.Windows.Forms.DataGridView dgwproducts;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Label lblAra;
        private System.Windows.Forms.Button button1;
    }
}

