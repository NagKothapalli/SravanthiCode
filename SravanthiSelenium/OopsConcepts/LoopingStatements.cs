using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SravanthiSelenium.OopsConcepts
{
    [TestClass]
    public class LoopingStatements
    {
        [TestMethod]
        public void ApplyColor()
        {
            Console.WriteLine("Apply Color to Step 1");
            Console.WriteLine("Apply Color to Step 2");
            Console.WriteLine("Apply Color to Step 3");
            Console.WriteLine("Apply Color to Step 4");
            Console.WriteLine("Apply Color to Step 5"); //..................
        }
        [TestMethod]
        public void ApplyColorToSteps()
        {
            //for(int iterator=1;expression;stepsize){ Task }
            for(int i=1;i<=50;i=i+1)  // 2<50 3<50 4<50 49<50 50<50 50<=50
            { //true
                Console.WriteLine("Apply Color to Step "+ i); // i=1,2,3,4 .......48,49
            }
        }
        //Write a program to generate even numbers in the range of 1 - 50
        [TestMethod]
        public void GenerateEvenNumbers()
        {
            for(int i=1;i<=50;i++) // i++ : i = i+1
            {
                int reminder = (i % 2); // i = 1 2 3 4 5 6 7 8 ....
                Console.WriteLine("My Number : " + i);
                if (reminder == 0)
                { //true
                    Console.WriteLine("******************Even Number : "+ i);
                }
            }
        }
        [TestMethod]
        public void GenerateOddNumbers()
        {
            for (int i = 1; i <= 50; i++) // i++ : i = i+1
            {
                int reminder = (i % 2); // i = 1 2 3 4 5 6 7 8 ....
                Console.WriteLine("My Number : " + i);
                if (!(reminder == 0))
                { //true
                    Console.WriteLine("******************Odd Number : " + i);
                }
            }
        }
        //Apply color to alternate steps
        [TestMethod]
        public void ApplyGreenColor()
        {
            for(int i=1;i<=50;i=i+2)
            {
                Console.WriteLine("Apply Green Color to Step " + i);  // 1+2+2+2+2
            }
        }
        [TestMethod]
        public void ApplyGreenColorFromFifty()
        {
            for (int i = 51; i <= 100; i = i + 2)
            {
                Console.WriteLine("Apply Green Color to Step " + i);  // 1+2+2+2+2
            }
        }
        //Apply color to alternate steps
        [TestMethod]
        public void ApplyRedColor()
        {
            for (int i = 2; i <= 50; i = i + 2)
            {
                Console.WriteLine("Apply Red Color to Step " + i);  // 2+2+2+2 ....
            }
        }

        [TestMethod]
        public void FindStudent()
        {
            for(int i=1;i<=60;i++)
            {
                Console.WriteLine("Student Searched : " + i);
                if(i == 22)
                {
                    Console.WriteLine("Student Found  " );
                    break;
                }
                
            }
        }
















    }
}

