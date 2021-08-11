using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void MyDelegate();
    public delegate void MyDelegate2(string text);
    public delegate int MyDelegate3(int number1, int number2);
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            //customerManager.SendMessage();
            //customerManager.AlertMessage();

            MyDelegate myDelegate = customerManager.SendMessage;
            myDelegate += customerManager.AlertMessage;
            //myDelegate -= customerManager.SendMessage;

            myDelegate();

            MyDelegate2 myDelegate2 = customerManager.SendMessage2;
            myDelegate2 += customerManager.AlertMessage2;

            myDelegate2("");

            Matematik matematik = new Matematik();
            MyDelegate3 myDelegate3 = matematik.topla;
            myDelegate3 += matematik.çarp;

            var sonic = myDelegate3(2, 3);
            Console.WriteLine(sonic);
            

            Console.ReadLine();
        }
    }

    public class CustomerManager
    {
        public void SendMessage()
        {
            Console.WriteLine("Hello!");
        }

        public void AlertMessage()
        {
            Console.WriteLine("Alert!");
        }

        public void SendMessage2(string hello)
        {
            Console.WriteLine("Hello!");
        }

        public void AlertMessage2(string alert)
        {
            Console.WriteLine("Alert!");
        }
    }
    public class Matematik
    {
        public int topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public int çarp(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
    }

}
