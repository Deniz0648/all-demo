using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace InterFaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //IntarFacesIntro();
            //Demo();
            //Demo2();

            Console.ReadLine();
        }

        private static void Demo2()
        {
            ICustomerDal[] customerDals = new ICustomerDal[3]
            {
                new SqlServerCustomerDal(),
                new OracleCustomerDal(),
                new MysqlCustomerDal()
            };

            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }
        }

        private static void Demo()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new OracleCustomerDal());
        }

        private static void IntarFacesIntro()
        {
            PersonMenager menager = new PersonMenager();
            Customer customer = new Customer
            {
                Id = 1,
                FirstName = "Deniz",
                LastName = "ÇAKMAK",
                Address = "Muğla/Fethiye"
            };

            Student student = new Student
            {
                Id = 2,
                FirstName = "Mehmet",
                LastName = "GÜRBOĞA",
                Departman = "Grafik"
            };


            menager.add(customer);
            menager.add(student);
        }

        interface IPerson
        {
            int Id { get; set; }
            string FirstName { get; set; }
            string LastName { get; set; }
        }

        class Customer : IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Address { get; set; }
        }

        class Student : IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Departman { get; set; }
        }

        class PersonMenager
        {
            public void add(IPerson person)
            {
                Console.WriteLine(person.Id + " " + person.FirstName + " " + person.LastName);

            }
        }
    }
}
