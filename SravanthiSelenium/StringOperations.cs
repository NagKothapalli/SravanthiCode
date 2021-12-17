using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SravanthiSelenium
{
    [TestClass]
    public class StringOperations
    {
        string A = "       Selenium with Csharp            ";
        string B = "    Selenium with CSHARP           ";
        string C = "CSHARP";
        [TestMethod]
        public void StringFunctions()
        {
            int len = A.Length; //With spaces
            Console.WriteLine("Length of the string :" + len);
            string AT = A.Trim();
            Console.WriteLine("Length of the string after trim :" + AT.Length); //Without spaces
            string AU = A.Trim().ToUpper();
            Console.WriteLine("String after Uppercase  :" + AU);
            string AL = A.Trim().ToLower();
            Console.WriteLine("String after Lowercase  :" + AL);
        }

        [TestMethod]
        public void StringComparision()
        {
          // Boolean Result =  A.Equals(B);
          // Boolean Result = A.Trim().Equals(B.Trim());
           //Boolean Result = A.Trim().ToUpper().Equals(B.Trim().ToUpper());
          // Boolean Result = A.Trim().ToLower().Equals(B.Trim().ToLower());
            Boolean Result = A.Trim().Equals(B.Trim(), StringComparison.InvariantCultureIgnoreCase);
            if (Result == true)
           {
                Console.WriteLine("Both A and B are same :");
           }
           else
           {
                Console.WriteLine("Both A and B are not same :");
           }
        }

        [TestMethod]
        public void StringContains()
        {
            if(A.Trim().ToUpper().Contains(C.Trim().ToUpper()))
            {
                Console.WriteLine("A contains C");
            }
            else
            {
                Console.WriteLine("C is not in A");
            }
        }
        [TestMethod]
        public void SubString()
        {
          string A8 =  A.Trim().Substring(8);
           Console.WriteLine("String A from 8th char :"+ A8);
           string A84 =  A.Trim().Substring(8, 4);
            Console.WriteLine("String A from 8th to 4 chars :" + A84);
        }
        [TestMethod]
        public void CharacterAt()
        {
            int Count = 0;
            Char C0 = A.Trim().ElementAt(0);
            Console.WriteLine("Char at 0th :" + C0);
            int len = A.Trim().Length;
            for(int i=0;i<len;i++)
            {
                if(A.Trim().ToUpper().ElementAt(i) == 'X') // S e l e n i u m 
                {
                    Count = Count + 1;
                }
            }
            Console.WriteLine("Char Count  :" + Count);
        }

        //Split - Array[]
    }
}
