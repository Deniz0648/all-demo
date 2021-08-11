using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayers
{
    class EntityOgretmen
    {
        private int OgrmId;
        private string OgrmAd;
        private int OgrmBrans;

        public int OGRMID
        {
            get => OgrmId; set => OgrmId = value;
        }
        public string OGRMAD
        {
            get => OgrmAd; set => OgrmAd = value;
        }
        public int OGRMBRANS
        {
            get => OgrmBrans; set => OgrmBrans = value;
        }
    }
}
