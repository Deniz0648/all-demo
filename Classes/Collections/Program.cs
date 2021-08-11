using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array();
            //ArrayList();
            //StringList();
            //PropList();

            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("Book","Kitap");
            dictionary.Add("Table","Tablo");
            dictionary.Add("Computer","Bilğisayar");

            //Console.WriteLine(dictionary["Table"]);

            foreach (var item in dictionary)
            {
                Console.WriteLine(item.Value);
            }

            Console.WriteLine("Anahtar kelime: {0}",dictionary.ContainsKey("Table"));
            


            Console.ReadLine();
        }

        private static void PropList()
        {
            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer {Id = 1, FirstName = "Deniz"});
            customers.Add(new Customer {Id = 2, FirstName = "Mehmet"});

            var customer1 = new Customer
            {
                Id = 3,
                FirstName = "Zeynep"
            };
            customers.Add(customer1);
            customers.AddRange(new Customer[2]
            {
                new Customer {Id = 4, FirstName = "İlker"},
                new Customer {Id = 5, FirstName = "Ali"}
            });

            //Console.WriteLine(customers.Contains(customer1));
            //customers.Clear();


            //customers.Remove(customer1);
            //.RemoveAll(c=>c.FirstName=="Zeynep");
            var index = customers.IndexOf(customer1);
            var index2 = customers.LastIndexOf(customer1);
            //customers.Insert(4,customer1);
            //customers.RemoveAll(c=>c.FirstName=="Zeynep");
            var count = customers.Count;

            foreach (var customer in customers)
            {
                Console.WriteLine(customer.Id);
                Console.WriteLine(customer.FirstName);
            }


            Console.WriteLine("Count: {0}", count);
            Console.WriteLine("İndex: {0}", index);
            Console.WriteLine("Last İndex: {0}", index2);
        }

        private static void StringList()
        {
            List<string> cities = new List<string>();
            cities.Add("Ankara");
            cities.Add("İstanbul");

            Console.WriteLine(cities.Contains("Ankara"));

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }
        }

        private static void Array()
        {
            string[] cities = new string[2] { "Ankara", "İstanbul" };
            cities = new string[3];
            Console.WriteLine(cities[0]);
            cities[1] = "Adana";
        }

        private static void ArrayList()
        {
            ArrayList cities = new ArrayList();
            cities.Add("Ankara");
            cities.Add("İstanbul");

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }

            cities.Add("Muğla");
            Console.WriteLine(cities[2]);
        }

        class Customer
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
        }

    }
}
