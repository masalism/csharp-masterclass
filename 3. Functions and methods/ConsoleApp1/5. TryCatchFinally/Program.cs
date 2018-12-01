﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.TryCatchFinally
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            string userInput = Console.ReadLine();

            int num1 = 5;
            int num2 = 0;
            int result;

            try
            {
                result = num1 / num2;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cant divide by zero");
            }


            try
            {
                int userInputAsInt = int.Parse(userInput);
            }
            catch (FormatException)
            {
                Console.WriteLine("Format exception, please enter the correct type next time");
                
            }
            catch (OverflowException)
            {
                Console.WriteLine("Overflow Exeption, the number wass too long or short for int32");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("ArgumentNullException Exeption, the value wass empty(null)");
            }
            finally
            {
                Console.WriteLine("This is called anyways");
            }
           
            Console.ReadKey();
        }
    }
}
