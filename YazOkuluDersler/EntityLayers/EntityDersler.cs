using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayers
{
    class EntityDersler
    {
        private string dersAd;
        private int Min;
        private int Max;
        private int id;

        public string DERSAD
        {
            get => dersAd; set => dersAd = value;
        }
        public int MIN
        {
            get => Min; set => Min = value;
        }
        public int MAX
        {
            get => Max; set => Max = value;
        }
        public int ID
        {
            get => id; set => id = value;
        }
    }
}
