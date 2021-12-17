using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SravanthiConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Welcome to Selenium Java");
            Debug.WriteLine("Welcome to Selenium Java");
            //Addition(); //Calling a function from main method
            Subtraction();
            Multiplication();
            Division();
            Subtraction();
            Multiplication();
            Division();
            Subtraction();
            Multiplication();
            Division();
            Subtraction();
            Multiplication();
            Division();
            Subtraction();
            Multiplication();
            Division();
            Subtraction();
            Multiplication();
            Division();
            Subtraction();
            Multiplication();
            Division();
            Subtraction();
            Multiplication();
            Division();
        }
        public static void Addition()
        {
            //Body
            int Sum = 22 + 44;
            Debug.WriteLine("Sum of Two Numbers : " + Sum);
        }
        public static void Subtraction()
        {
            //Body
            int Sum = 22 - 44;
            Debug.WriteLine("Subtraction of Two Numbers : " + Sum);
        }
        public static void Multiplication()
        {
            //Body
            int Sum = 22 * 44;
            Debug.WriteLine("Multiplication of Two Numbers : " + Sum);
        }
        public static void Division()
        {
            //Body
            int Sum = 262 / 44;
            Debug.WriteLine("Division of Two Numbers : " + Sum);
        }

    }
}
