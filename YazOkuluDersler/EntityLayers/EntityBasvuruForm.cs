using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayers
{
    class EntityBasvuruForm
    {
        private int basvuruid;
        private int basdersid;
        private int basogrid;

        public int BASVURUID
        {
            get => basvuruid; set => basvuruid = value;
        }
        public int BaASDERSID
        {
            get => basdersid; set => basdersid = value;
        }
        public int BASOGRID
        {
            get => basogrid; set => basogrid = value;
        }
    }
}
