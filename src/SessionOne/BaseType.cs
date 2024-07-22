

// basetype.cs
using System;

namespace MyConsoleApp.src.SessionOne
{
    public class BaseType
    {
        public static void Run()
        {
            int numOne = 12;
            int numTwo = 20;
            int sum = numOne + numTwo;

            DateTime currentTime = DateTime.Now;

            const string firstName = "Alish";

            System.Console.WriteLine("the sum is " + sum);
            System.Console.WriteLine("this name is " + firstName.ToUpper() + "" + numOne.ToString());
            System.Console.WriteLine($"time: {currentTime}");
            System.Console.WriteLine("\nTypes:");
            System.Console.WriteLine($"numOne >> {numOne.GetType()}");
        }
    }
}