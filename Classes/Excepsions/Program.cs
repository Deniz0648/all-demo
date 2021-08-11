using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Excepsions
{
    class Program
    {
        static void Main(string[] args)
        {
            //ExceptionIntro();
            //Find();
            //Method
            //HandleException(Find);
            //HandleException(()=>{ExceptionIntro();});

            Func<int, int, int> add = Topla;
            Console.WriteLine(add(3,5));

            Func<int> getRandomNumber = delegate()
            {
                Random random = new Random();
                return random.Next(1, 100);
            };

            Console.WriteLine(getRandomNumber());

            //Console.WriteLine(Topla(2, 3));
            Console.ReadLine();
        }

        static int Topla(int x, int y)
        {
            return x + y;
        }


        private static void HandleException(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (RecordNotFoundExcepsion exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private static void Find()
        {
            List<string> students = new List<string>
            {
                "Deniz",
                "Mehmet",
                "Zeynep"
            };
            if (!students.Contains("İlker"))
            {
                throw new RecordNotFoundExcepsion("Record Not Found!");
            }
            else
            {
                Console.WriteLine("Record Found!");
            }
        }

        private static void ExceptionIntro()
        {
            try
            {
                string[] student = new string[3]
                {
                    "Deniz",
                    "Mehmet",
                    "Zeynep"
                };
                student[3] = "İlker";
            }
            catch (IndexOutOfRangeException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
