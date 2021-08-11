using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using EntityLayer;


namespace DataAccessLayer
{
    public class DalDersler
    {
        //Öğrenci Listeleme Komutu

        public static List<EntityDersler> DersListesi()
        {
            List<EntityDersler> degerler = new List<EntityDersler>();

            SqlCommand komut1 = new SqlCommand("Select * From tbl_DERS", Baglanti.bgl);

            if (komut1.Connection.State != ConnectionState.Open)
            {
                komut1.Connection.Open();
            }
            SqlDataReader dr = komut1.ExecuteReader();
            while (dr.Read())
            {
                EntityDersler ent = new EntityDersler();
                ent.ID = Convert.ToInt32(dr["dersID"].ToString());
                ent.DERSAD = dr["dersAD"].ToString();
                ent.MIN = int.Parse(dr["ders_min_KONT"].ToString());
                ent.MAX = int.Parse(dr["ders_max_KONT"].ToString());
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }

        //Ders Talep Ekleme Komutu

        public static int TalepEkle(EntityBasvuruForm parametre)
        {
            SqlCommand komut = new SqlCommand("insert into tbl_bvr_FORM (ogrID,dersID) values (@p1,@p2 )", Baglanti.bgl);
            komut.Parameters.AddWithValue("@p1", parametre.BASOGRID);
            komut.Parameters.AddWithValue("@p2", parametre.BASDERSID);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            return komut.ExecuteNonQuery();

        }
    }
}
