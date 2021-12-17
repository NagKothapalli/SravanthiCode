using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SravanthiSelenium.OopsConcepts
{
    [TestClass]
    public class ConditionalStatements
    {
        [TestMethod]
        public void CompareTwoNumbers_Test()
        {
            CompareTwoNumbers(20,20);
            CompareTwoNumbers(40, 20);
        }
        //if(expression - > boolean : true / false) {  Task }
        public void CompareTwoNumbers(int a, int b)
        {
            Console.WriteLine("A value :" + a);
            Console.WriteLine("B value :" + b);
            if (a==b)
            { //true
                int sum = a + b;
                Console.WriteLine("Both A and B are equal , Sum : "  + sum);
            }
        }
        [TestMethod]
        public void CompareTwoNumbers_ifelse_Test()
        {
            CompareTwoNumbers_ifelse(45, 45);
            CompareTwoNumbers_ifelse(45, 85);
        }
        public void CompareTwoNumbers_ifelse(int a, int b)
        {
            Console.WriteLine("A value :" + a);
            Console.WriteLine("B value :" + b);
            if (a == b)
            { //true
                int sum = a + b;
                Console.WriteLine("Both A and B are equal , Sum : " + sum);
            }
            else //false
            {
                int Diff = a - b;
                Console.WriteLine("Both A and B are not equal , Diff : " + Diff);
            }
        }
        //Write a program to read two inputs if they are equal perform addition , if a > b then subtraction , if a < b then multiplication
        [TestMethod]
        public void WorkWithElseIf_Test()
        {
            WorkWithElseIf(44,88); //5/15 * 100 = 33.333 code coverage
            WorkWithElseIf(44, 44);
            WorkWithElseIf(144, 88);
        }
        public void WorkWithElseIf(int a , int b)  // source code
        {
            Console.WriteLine("A value :" + a);
            Console.WriteLine("B value :" + b);
            if (a == b)
            { //true
                int sum = a + b;
                Console.WriteLine("Both A and B are equal , Sum : " + sum);
            }
            else if(a>b) //false
            {
                int Diff = a - b;
                Console.WriteLine("A is above B , Diff : " + Diff);
            }
            else if(a<b)
            {
                int prod = a * b;
                Console.WriteLine("A is below B , prod : " + prod);
            }
        }
        //Perform the below task , if snd only if both inputs are above 10
        //Task : Write a program to read two inputs if they are equal perform addition , if a > b then subtraction , if a < b then multiplication
        [TestMethod] //TDD : Test Driven Development
        public void LogicalOperator_Test()
        {
            LogicalOperator(4, 8);
            LogicalOperator(14, 8);
            LogicalOperator(4, 18);
            LogicalOperator(44, 38);
            LogicalOperator(44, 88);
            LogicalOperator(44, 44);
        }
        public void LogicalOperator(int a,int b)
        {
            Console.WriteLine("A value :" + a);
            Console.WriteLine("B value :" + b);
            //   T          T   -> T
            if ((a>10) && (b >10))
            { //T
                //Task - open door
                if (a == b)
                { //true
                    int sum = a + b;
                    Console.WriteLine("Both A and B are equal , Sum : " + sum);
                }
                else if (a > b) //false
                {
                    int Diff = a - b;
                    Console.WriteLine("A is above B , Diff : " + Diff);
                }
                else if (a < b)
                {
                    int prod = a * b;
                    Console.WriteLine("A is below B , prod : " + prod);
                }
            }
            else
            { //F
                Console.WriteLine("Both A and B or anyone of them might be below 10 " );
            }
        }

     //Write a program to read a number and find is that even or odd number
        [TestMethod]
        public void FindEvenOrOdd_Test()
        {
            FindEvenOrOdd(1);
            FindEvenOrOdd(2);
            FindEvenOrOdd(3);
            FindEvenOrOdd(4); //....................1000
        }
        public void FindEvenOrOdd(int num) //46
        {
            Console.WriteLine("Given Number is : " + num);
            // N / D : Q  ,    N % D : R if R==0 then even
            int reminder = (num % 2);
            if(reminder == 0)
            { //true
                Console.WriteLine("Given Number is Even ");
            }
            else
            {
                Console.WriteLine("Given Number is  not a Even / Odd ");
            }
        }















    }
}
