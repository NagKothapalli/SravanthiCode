using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SravanthiSelenium.OopsConcepts
{
    [TestClass]
    public class GmailAutomation
    {
        //********************TestCases*********************************
        [TestMethod]
        public void ComposeAndSendAnEmail()
        {
            Console.WriteLine("Test Case : ComposeAndSendAnEmail ");
            //launch - 10 lines , login - 10 lines , compose , send , logout , close
            LaunchApplication();
            LoginToApplication();
            Compose();
            Send();
            LogoutFromApplication();
            CloseApplication();
        }
        [TestMethod]
        public void ReplyToAnEmail()
        {
            Console.WriteLine("Test Case : ReplyToAnEmail ");
            //launch , login , compose , send , logout , close
            LaunchApplication();
            LoginToApplication();
            Open();
            Reply();
            LogoutFromApplication();
            CloseApplication();
        }
        [TestMethod]
        public void ForwardAnEmail()
        {
            Console.WriteLine("Test Case : ForwardAnEmail ");
            //launch , login , compose , send , logout , close
            LaunchApplication();
            LoginToApplication();
            Open();
            Forward();
            LogoutFromApplication();
            CloseApplication();
        }
        [TestMethod]
        public void DeleteAnEmail()
        {
            Console.WriteLine("Test Case : DeleteAnEmail ");
            //launch , login , compose , send , logout , close
            LaunchApplication();
            LoginToApplication();
            Open();
            Delete();
            LogoutFromApplication();
            CloseApplication();
        }

        //*********************ReusableComponents********************
        private void LaunchApplication()
        {
            Console.WriteLine("RC : LaunchApplication ");
        }
        public void LoginToApplication()
        {
            Console.WriteLine("RC : LoginToApplication ");
        }
        private void LogoutFromApplication()
        {
            Console.WriteLine("RC : LogoutFromApplication ");
        }
        protected void CloseApplication()
        {
            Console.WriteLine("RC : CloseApplication ");
        }
        public void Compose()
        {
            Console.WriteLine("RC : Compose Mail ");
        }
        public void Open()
        {
            Console.WriteLine("RC : Open Mail ");
        }
        public void Reply()
        {
            Console.WriteLine("RC : Reply Mail ");
        }
        public void Forward()
        {
            Console.WriteLine("RC : Forward Mail ");
        }
        public void Send()
        {
            Console.WriteLine("RC : Send Mail ");
        }
        public void Delete()
        {
            Console.WriteLine("RC : Delete Mail ");
        }
    }
}
