using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SravanthiSelenium.Inheritance
{
    [TestClass] // Base            Parent
    public class TestCases : ReusableComponents
    {
        public void LaunchApplication()
        {
            Console.WriteLine("RC : LaunchApplication from TC");
        }
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

    }
}
