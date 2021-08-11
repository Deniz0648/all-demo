using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using EntityLayer;

namespace DataAccessLayer
{

    
    public class DalOgrenci
    {
        //Öğrenci Ekleme komutu
        public static int OgrenciEkle(EntityOgrenci parametre)
        {
            SqlCommand komut1 = new SqlCommand("insert into tbl_OGR (ogrAD,ogrSOYAD,ogrNUMARA,ogrFOTO,ogrSIFRE) values (@p1,@p2,@p3,@p4,@p5)", Baglanti.bgl);

            if (komut1.Connection.State != ConnectionState.Open)
            {
                komut1.Connection.Open();
            }
            komut1.Parameters.AddWithValue("@p1", parametre.AD);
            komut1.Parameters.AddWithValue("@p2", parametre.SOYAD);
            komut1.Parameters.AddWithValue("@p3", parametre.NUMARA);
            komut1.Parameters.AddWithValue("@p4", parametre.FOTOGRAF);
            komut1.Parameters.AddWithValue("@p5", parametre.SIFRE);
            return komut1.ExecuteNonQuery();
        }

        //Öğrenci Listeleme Komutu
        
        public static List <EntityOgrenci> OgrenciListesi()
        {
            List<EntityOgrenci> degerler = new List<EntityOgrenci>();
            
            SqlCommand komut2 = new SqlCommand("Select * From tbl_OGR", Baglanti.bgl);
            
            if (komut2.Connection.State != ConnectionState.Open)
            {
                komut2.Connection.Open();
            }
            SqlDataReader dr = komut2.ExecuteReader();
            while (dr.Read())
            {
                EntityOgrenci ent = new EntityOgrenci();
                ent.ID = Convert.ToInt32(dr["ogrID"].ToString());
                ent.AD = dr["ogrAD"].ToString();
                ent.SOYAD = dr["ogrSOYAD"].ToString();
                ent.NUMARA = dr["ogrNUMARA"].ToString();
                ent.FOTOGRAF = dr["ogrFOTO"].ToString();
                ent.SIFRE = dr["ogrSIFRE"].ToString();
                ent.BAKİYE = Convert.ToDouble(dr["ogrBAKIYE"].ToString());
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }

        //Öğrenci Silme Komutu
        public static bool OgrenciSil (int parametre)
        {
            SqlCommand komut3 = new SqlCommand("Delete From tbl_OGR Where ogrID=@p1", Baglanti.bgl);
            if (komut3.Connection.State != ConnectionState.Open)
            {
                komut3.Connection.Open();
            }
            komut3.Parameters.AddWithValue("@p1", parametre);
            return komut3.ExecuteNonQuery() > 0;
        }

        //Öğrenci Detaylarını Güncelleme Sayfasındaki TextBoxlara Aktarma
        public static List<EntityOgrenci> OgrenciDetay(int id)
        {
            List<EntityOgrenci> degerler = new List<EntityOgrenci>();

            SqlCommand komut4 = new SqlCommand("Select * From tbl_OGR Where ogrID=@p1", Baglanti.bgl);
            komut4.Parameters.AddWithValue("@p1", id);

            if (komut4.Connection.State != ConnectionState.Open)
            {
                komut4.Connection.Open();
            }
            SqlDataReader dr = komut4.ExecuteReader();
            while (dr.Read())
            {
                EntityOgrenci ent = new EntityOgrenci();
                ent.AD = dr["ogrAD"].ToString();
                ent.SOYAD = dr["ogrSOYAD"].ToString();
                ent.NUMARA = dr["ogrNUMARA"].ToString();
                ent.FOTOGRAF = dr["ogrFOTO"].ToString();
                ent.SIFRE = dr["ogrSIFRE"].ToString();
                ent.BAKİYE = Convert.ToDouble(dr["ogrBAKIYE"].ToString());
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }

        public static bool OgrenciGuncelle(EntityOgrenci deger)
        {
            SqlCommand komut5 = new SqlCommand("Update tbl_OGR Set ogrAD=@p1, ogrSOYAD=@p2, ogrNUMARA=@p3, ogrFOTO=@p4, ogrSIFRE=@p5 Where ogrID=@p6", Baglanti.bgl);
            
            if (komut5.Connection.State != ConnectionState.Open)
            {
                komut5.Connection.Open();
            }

            komut5.Parameters.AddWithValue("@p1", deger.AD);
            komut5.Parameters.AddWithValue("@p2", deger.SOYAD);
            komut5.Parameters.AddWithValue("@p3", deger.NUMARA);
            komut5.Parameters.AddWithValue("@p4", deger.FOTOGRAF);
            komut5.Parameters.AddWithValue("@p5", deger.SIFRE);
            komut5.Parameters.AddWithValue("@p6", deger.ID);
            return komut5.ExecuteNonQuery() > 0;
        }
    }
}