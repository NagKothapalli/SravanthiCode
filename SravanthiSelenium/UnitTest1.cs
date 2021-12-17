using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SravanthiSelenium
{
    //Signature : 
    //Modifier  class Name{  Members : Variables / Functions }
    [TestClass]
    public class UnitTest1
    {
        //Signature : Variable
        //Modifier[opt]  DataType  Name ;    /     Modifier  DataType  Name = Value ;
        //Access  - private , public , protected
        //NonAccess - static , final
        public static String CollegeName = "JNTU";
        public int StdNum = 22;
        public char StdGrade = 'A';
        private Boolean StdResult = false;
        public double StdMarks = 99.6;
        //Signature : Function
        //Modifier[opt]    ReturnType   Name(arguments ... opt){  Body    }
        // { } - Curly   [] - square  () - paranthasis
        [TestMethod]
        public  void Addition()
        {
            //Body
            int Sum = 22 + 44;
            Console.WriteLine("Sum of Two Numbers : " + Sum );
        }
        [TestMethod]
        public void Subtraction()
        {
            //Body
            int Diff = 222 - 44;
            Console.WriteLine("Difference of Two Numbers : " + Diff);
        }
        [TestMethod] //Annotation
        public void ComposeAndSendMail()
        {
            //Console  myconsole = new Console();  -  myconsole.WriteLine();
            Console.WriteLine("Welcome to Selenium Java");
            //Selenium.get("https://gmail.com");
            //selenium
        }
        
        public void ReplyToEmail()
        {

        }
        
        public void ForwardEmail()
        {

        }
    }
}
