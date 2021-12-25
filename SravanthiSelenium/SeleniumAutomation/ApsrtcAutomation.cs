using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SravanthiSelenium.SeleniumAutomation
{
    [TestClass]
    public class ApsrtcAutomation
    {
        //class , variable , function
        String ExpectedTitle = "APSRTC Official Website for Online Bus Ticket Booking - APSRTConline.in";
        ChromeDriver driver;
        public ApsrtcAutomation()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            // driver.Manage().Window.Minimize();
        }

        [TestInitialize]
        public void LaunchApplication()
        {
            Console.WriteLine("RC : LaunchApplication");
            driver.Navigate().GoToUrl("https://www.apsrtconline.in/");
            String ActualTitle = driver.Title;
            Console.WriteLine("Title of browser :" + ActualTitle);
            Console.WriteLine("Currnet URL :" + driver.Url);
            Console.WriteLine("Session ID of my window" + driver.CurrentWindowHandle);
            if (ExpectedTitle.Equals(ActualTitle))
            {
                Console.WriteLine("Title Validation Passed");
            }
            else
            {
                Console.WriteLine("Title Validation Failed");
            }
            Assert.AreEqual(ExpectedTitle, ActualTitle);
        }
        [TestCleanup]
        public void CloseApplication()
        {
            Console.WriteLine("RC : CloseApplication");
            Thread.Sleep(2000);
            driver.Close();
        }
        [TestMethod]
        public void ValidateFromCityTextBox()
        {
            Console.WriteLine("Validate the Text box is displayed and Enabled and Read the Title of this Field");
            IWebElement FromCity = driver.FindElement(By.XPath("//input[@name='source']"));
            if(FromCity.Displayed)
            {
                //then do something
                if (FromCity.Enabled)
                {
                    //type something
                    //read the title attribute
                    string mytitle = FromCity.GetAttribute("title");
                    Console.WriteLine("Title  of the FromCity Field :"  + mytitle);
                    //Enter the City Name
                    FromCity.SendKeys("HYDERABAD");

                }
                else
                {
                    //dont type anything
                }
            }
            else
            {
                //not displayed
            }

        }
















    }
}
