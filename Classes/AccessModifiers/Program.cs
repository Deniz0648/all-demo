using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {



            Console.ReadLine();
        }
    }

    class Customer
    {
        protected int Id { get; set; }
        private int Id2 { get; set; }

        public void Save()
        {

        }
    }

    class Student : Customer
    {
        public void save2()
        {

        }
    }

    public class Course
    {
        public string Name { get; set; }
        private class NestedClass
        {

        }
    }
}

