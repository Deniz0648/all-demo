using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceAndValueType
{
    class Program
    {
        static void Main(string[] args)
        {
            int Number1 = 10;
            int Number2 = 20;
            Number2 = Number1;
            Number1 = 30;
            Console.WriteLine(Number2);

            string[] cities = new[] {"Ankara", "Muğla", "Antalya"};
            string[] cities2 = new[] {"İstanbul", "Balıkesir", "Bursa"};
            cities2 = cities;
            cities[0] = "İstanbul";
            Console.WriteLine(cities2[0]);

            DataTable dataTable = new DataTable();
            DataTable dataTable2;
            dataTable2 = dataTable;

            //dataTable.Load(new DataTableReader());


            Console.ReadLine();
        }

        class MyClass
        {
            
        }
    }
}
