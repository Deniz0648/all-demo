using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityCodeFirst.Entity
{
    public class Urunler
    {
        [Key]
        public int UrunID { get; set; }

        public string UrunAD { get; set; }
        public string UrunMARKA { get; set; }
        public string UrunKATEGORI { get; set; }
        public int UrunSTOK { get; set; }
    }
}
