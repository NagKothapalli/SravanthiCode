using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SravanthiSelenium.InheritanceByObject
{
    [TestClass]
    public class TestScenarios // : Default Inheritance
    {
        //A  : B : C  : Multilevel inheritance
        //A : B,C  : Multiple Inheritance
        //Modifier ClassName   objectName  = new Constructor();
       // public RComponents rc = new RComponents(); // Default Constructor 
       // public RComponents rc = new RComponents("firefox");
        public RComponents rc = new RComponents("firefox",85);
        //********************TestCases*********************************
        [TestMethod]
        public void ComposeAndSendAnEmail()
        {
            Console.WriteLine("Test Case : ComposeAndSendAnEmail ");
            //launch - 10 lines , login - 10 lines , compose , send , logout , close
            rc.LaunchApplication();
            rc.LoginToApplication();
            rc.Compose();
            rc.Send();
            rc.LogoutFromApplication();
            rc.CloseApplication();
        }
        [TestMethod]
        public void ReplyToAnEmail()
        {
            Console.WriteLine("Test Case : ReplyToAnEmail ");
            //launch , login , compose , send , logout , close
            rc.LaunchApplication();
            rc.LoginToApplication();
            rc.Open();
            rc.Reply();
            rc.LogoutFromApplication();
            rc.CloseApplication();
        }
        [TestMethod]
        public void ForwardAnEmail()
        {
            Console.WriteLine("Test Case : ForwardAnEmail ");
            //launch , login , compose , send , logout , close
            rc.LaunchApplication();
            rc.LoginToApplication();
            rc.Open();
            rc.Forward();
            rc.LogoutFromApplication();
            rc.CloseApplication();
        }
        [TestMethod]
        public void DeleteAnEmail()
        {
            Console.WriteLine("Test Case : DeleteAnEmail ");
            //launch , login , compose , send , logout , close
            rc.LaunchApplication();
            rc.LoginToApplication();
            rc.Open();
            rc.Delete();
            rc.LogoutFromApplication();
            rc.CloseApplication();
        }
    }
}
