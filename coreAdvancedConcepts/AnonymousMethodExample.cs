﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coreAdvancedConcepts
{
    public delegate void PrintMessage(string message);
    internal class AnonymousMethodExample
    {
        public static void InvokeMethod()
        {
            PrintMessage printMessage = delegate (string message)
            {
                Console.WriteLine("Message: "+ message);
            };
            printMessage("Hello World");
        }
    }
}
