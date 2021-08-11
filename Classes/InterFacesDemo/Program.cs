using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterFacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[3]
            {
                new Managers(),
                new Worker(),
                new Robot()
            };
            IEat[] eats = new IEat[2]
            {
                new Managers(),
                new Worker()
            };
            IGetSalary[] getSalaries = new IGetSalary[2]
            {
                new Managers(),
                new Worker()
            };

            foreach (var worker in workers)
            {
                worker.Work();
            }


            Console.ReadLine();
        }
    }

    interface IWorker
    {
        void Work();

    }
    interface IEat
    {
        void Eat();
    }
    interface IGetSalary
    {
        void GetSalary();
    }

    class Managers : IWorker, IEat, IGetSalary
    {
        public void Work()
        {
            
            Console.WriteLine("Working");
        }

        public void Eat()
        {
            Console.WriteLine("Eating");
        }

        public void GetSalary()
        {
            Console.WriteLine("Salary");
        }
    }

    class Worker : IWorker, IEat, IGetSalary
    {
        public void Work()
        {
            Console.WriteLine("Working");
        }

        public void Eat()
        {
            Console.WriteLine("Eat");
        }

        public void GetSalary()
        {
            Console.WriteLine("Salary");
        }
    }

    class Robot : IWorker
    {
        public void Work()
        {
            Console.WriteLine("Working");
        }
    }

}
