using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{

    //Property Bir class İçerisindeki Çok Değerli değişkendir.
    //Set Gönderilen Verilerin Kaydedilmesidir.
    //Get kaydedilen verilerin çağrımıdır.

    class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
