using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using EntityLayer;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class bllOgrenci
    {
        public static int OgrenciEkleBLL(EntityOgrenci p)
        {
            if (p.AD != null && p.SOYAD != null && p.NUMARA != null && p.SIFRE != null && p.FOTOGRAF != null)
            {
                return DalOgrenci.OgrenciEkle(p);
            }
            return -1;
        }

        public static List<EntityOgrenci> BllListele()
        {
            return DalOgrenci.OgrenciListesi();
        }

        public static bool OgrenciSil(int p)
        {
            if (p >=0 )
            {
                return DalOgrenci.OgrenciSil(p);
            }
            return false;
        }

        public static List<EntityOgrenci> BllDetay(int p)
        {
            return DalOgrenci.OgrenciDetay(p);
        }

        public static bool OgrenciGulcelle(EntityOgrenci p)
        {
            if (p.AD != null && p.SOYAD != null && p.NUMARA != null && p.SIFRE != null && p.FOTOGRAF != null && p.ID > 0)
            {
                return DalOgrenci.OgrenciGuncelle(p);
            }
            return false;
        }
    }
}
