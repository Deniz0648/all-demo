using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using EntityLayers;


namespace DataAccessLayer
{
    public class DalOgrenci
    {
        public static int OgrenciEkle(EntityOgrenci parametre) 
        {
            SqlCommand komut1 = new SqlCommand("insert into tbl_OGR (ogrAD,ogrSOYAD,ogrFOTO,ogrMAIL,ogrSIFRE) volues (@p1,@p2,@p3,@p4,@p5)", Baglanti.bgl);

            if (komut1.Connection.State != komut1.Con)
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
    }
}
