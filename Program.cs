﻿using System;
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
            int someNumber = Convert.ToInt32(ReadingInt());
            Console.WriteLine("\n"+someNumber);
        }

        static string ReadingInt()
        {
            bool successOfExecution = false;
            Console.WriteLine("Введите число");
            while (successOfExecution == false)
            {
                string someNumber = Console.ReadLine();
                successOfExecution = Int32.TryParse(someNumber,out int result);
                if(successOfExecution)
                {                   
                    return someNumber;
                }
                else
                {
                    Console.WriteLine("Невозможно преобразовать, введите число заново.");
                }
            }
            return "";
        }
    }
}
