﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coreAdvancedConcepts
{
    internal class Calculation
    {
        public void calculateAnother()
        {
            int num1, num2, result = 0;
            try
            {
                Console.Write("Enter Number One: ");
                num1 = int.Parse(Console.ReadLine());
                Console.Write("Enter Number Two: ");
                num2 = int.Parse(Console.ReadLine());
                result = num1 / num2;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Exception Occured.");
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Exception Occured.");
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Occured.");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("I will always execute.");
                Console.WriteLine(result);
            }
        }
    }
}
