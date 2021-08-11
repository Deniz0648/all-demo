using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Müşteri işlemlerini kullanma
            CustomerManager customerManager = new CustomerManager();
            customerManager.add();
            customerManager.update();

            Console.WriteLine(" ");

            //Ürün işlemlerini Kullanma
            ProducyManager producyManager = new ProducyManager();
            producyManager.add();
            producyManager.update();

            Customer customer = new Customer
            {
                Id = 1,
                City = "Muğla/Fethiye",
                FirstName = "Deniz", 
                LastName = "ÇAKMAK"
            };

            Customer customer2 = new Customer
            {
                Id = 2,
                City = "Muğla/Fethiye",
                FirstName = "Mehmet",
                LastName = "GÜRBOĞA"
            };

            Console.WriteLine(customer.FirstName);

            Console.ReadLine();
        }
    }
}
