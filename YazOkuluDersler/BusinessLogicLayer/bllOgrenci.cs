using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using EntityLayers;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class bllOgrenci
    {
        public static int OgrenciEkleBLL(EntityOgrenci p)
        {
            if (p.AD !=null && p.SOYAD != null && p.NUMARA != null && p.SIFRE != null && p.FOTOGRAF != null)
            {
                return DalOgrenci.OgrenciEkle(p);
            }
            return -1;
        }
    }
}
