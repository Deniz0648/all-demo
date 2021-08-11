using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            //CustomerManager customerManager = new CustomerManager(20);
            //customerManager.Add();
            //customerManager.List();

            //Product product = new Product { Id = 1, Name = "laptop" };
            //Product product1 = new Product(2, "Computer");

            //Console.WriteLine(product.Name);

            //EmployeeMenager employeeMenager = new EmployeeMenager(new DatabaseLoger());
            //employeeMenager.Add();

            //PersonMenager personMenager = new PersonMenager("Product");
            //personMenager.Add();

            //Teacher.Number = 10;
            //Utilities.Validate();

            Manager.DoSomething();

            Manager manager = new Manager();
            manager.DoSomething2();

            Console.ReadLine();
        }
    }

    class CustomerManager
    {
        private int _count = 15;
        public CustomerManager(int count)
        {
            _count = count;
        }
        public CustomerManager()
        {

        }

        public void List()
        {
            Console.WriteLine("listed {0} items", _count);
        }

        public void Add()
        {
            Console.WriteLine("Added");
        }
    }

    class Product
    {
        public Product()
        {

        }

        private int _id;
        private string _name;

        public Product(int id, string name)
        {
            _id = id;
            _name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }
    interface ILogger
    {
        void Log();
    }

    class DatabaseLoger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to Database");
        }
    }

    class FileLoger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to File");
        }
    }

    class EmployeeMenager
    {
        private ILogger _logger;
        public EmployeeMenager(ILogger logger)
        {
            _logger = logger;
        }

        public void Add()
        {
            _logger.Log();
            Console.WriteLine("Added");
        }
    }

    class BaseClass
    {
        private string _entity;

        public BaseClass(string entity)
        {
            _entity = entity;
        }

        public void Message()
        {
            Console.WriteLine("{0} message",_entity);
        }
    }

    class PersonMenager:BaseClass
    {
        public PersonMenager(string entity) : base(entity)
        {

        }

        public void Add()
        {
            Console.WriteLine("Added");
            Message();
        }
    }

    static class Teacher
    {
        public static int Number { get; set; }
    }

    static class Utilities
    {
        public static void Validate()
        {
            Console.WriteLine("validation is Done");
        }
    }

    class Manager
    {
        public static void DoSomething()
        {
            Console.WriteLine("Something is Done");
        }

        public void DoSomething2()
        {
            Console.WriteLine("2. Something is Done");
        }
    }


}