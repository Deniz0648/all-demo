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
    public class BllDersler
    {
        public static List<EntityDersler> BllListele()
        {
            return DalDersler.DersListesi();
        }

        public static int TalepEkleBll(EntityBasvuruForm p)
        {
            if (p.BASOGRID != null && p.BASDERSID != null)
            {
                return DalDersler.TalepEkle(p);
            }
            return -1;
        }
    }
}
