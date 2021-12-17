using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SravanthiSelenium.OopsConcepts
{
    [TestClass]
    public class Collections
    {
        //Fixed collection 
        //DataType[]  name = {values .......};
        //Declare , Assign , length , read , write
        [TestMethod]
        public void FixedCollection()
        {
            //               0 1  2  3  4  5   6  7    8
            int[] numbers = {2,22,44,26,32,38,48,58 };
            int len = numbers.Length;
            Console.WriteLine("Length of the array :" + len);
            int val = numbers[5];  // reading
            numbers[10] = 12;   // writing
            for(int i=0;i<len;i++)  // 7 <= 8 ,  8 <=8
            {
                Console.WriteLine("Values from Collection :" + numbers[i] ); // numbers[0] - 2 ,  numbers[1] - 22 ,  numbers[2] - 44
            }
            for (int i = 0; i < len; i++)
            {
                numbers[i] = 222+i; //222+0  , 222+1 , 222+2
                Console.WriteLine("Values in to Collection :" + numbers[i]); 
            }
        }

        [TestMethod]
        public void DynamicCollection()
        {
            //               0 1  2  3  4  5   6  7
            //int[] numbers = { 2, 22, 44, 26, 32, 38, 48, 58 };
            int[] numbers = new int[10];
            int len = numbers.Length;
            Console.WriteLine("Length of the array :" + len);
            int val = numbers[0];  // reading
            //numbers[0] = 12;   // writing
            for (int i = 0; i < len; i++)
            {
                Console.WriteLine("Values from Collection :" + numbers[i]); // numbers[0] - 2 ,  numbers[1] - 22 ,  numbers[2] - 44
            }
            for (int i = 0; i < len; i++)
            {
                numbers[i] = 222 + i; //222+0  , 222+1 , 222+2
                Console.WriteLine("Values in to Collection :" + numbers[i]);
            }
        }
        [TestMethod]
        public void ArrayListCollection()
        {
            //               0 1  2  3  4  5   6  7
            //int[] numbers = { 2, 22, 44, 26, 32, 38, 48, 58 };
            //int[] numbers = new int[10];
            IList<int> numbers = new List<int>();
            int len = numbers.Count;
            Console.WriteLine("Length of the array :" + len);
            //int val = numbers[0];  // reading
            //numbers[0] = 12;   // writing
            for (int i = 0; i < len; i++)
            {
                Console.WriteLine("Values from Collection :" + numbers[i]); // numbers[0] - 2 ,  numbers[1] - 22 ,  numbers[2] - 44
            }
            for (int i = 0; i < 10; i++)
            {
                numbers.Add(222 + i);
                //numbers[i] = 222 + i; //222+0  , 222+1 , 222+2
                Console.WriteLine("Values in to Collection :" + numbers.ElementAt(i));
            }
            Console.WriteLine("Length of the array after writing :" + numbers.Count);
        }
    }
}
