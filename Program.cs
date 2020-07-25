using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson43
{
    class Program
    {
        static void Main(string[] args)
        {
            ConvertationToNumber();
        }

        static void ConvertationToNumber()
        {            
            bool successOfExecution = false;
            Console.WriteLine("Введите число");
            while (successOfExecution == false)
            {
                string someNumber = Console.ReadLine();
                successOfExecution = Int32.TryParse(someNumber,out int result);
                if(successOfExecution)
                {
                    Console.WriteLine(result);
                    successOfExecution = true;
                }
                else
                {
                    Console.WriteLine("Невозможно преобразовать, введите число заново.");
                }
            }
        }
    }
}
