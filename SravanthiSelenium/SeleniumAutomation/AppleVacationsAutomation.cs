using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SravanthiSelenium.SeleniumAutomation
{
    [TestClass]
    public class AppleVacationsAutomation
    {
        String ExpectedTitle = "AppleVacations.com | Caribbean, Mexico and Hawaii Vacation Packages - All Inclusive Resorts";
        ChromeDriver driver;
        public AppleVacationsAutomation()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            // driver.Manage().Window.Minimize();
        }

        [TestInitialize]
        public void LaunchApplication()
        {
            Console.WriteLine("RC : LaunchApplication");
            driver.Navigate().GoToUrl("https://www.applevacations.com/#");
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

        public void ExplicitWait(String myxpath,int MaxTimeInSec)
        {
            for (int i = 0; i < MaxTimeInSec; i++)
            {
                Console.WriteLine(i);
                if (driver.FindElements(By.XPath(myxpath)).Count > 0)
                {
                    driver.FindElement(By.XPath(myxpath)).Click();
                    break;
                }
                else
                {
                    Thread.Sleep(1000);
                }
            }
        }
        [TestMethod]
        public void BookVacationPlan()
        {
            Console.WriteLine("TestCase : Book a Vacation");
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            //Thread.Sleep(5000);   //static - blind
            //driver.Manage().Timeouts().ImplicitWait.Equals(TimeSpan.FromSeconds(20));  
            ExplicitWait("//button[text()='Decline Offer']", 15);
            //driver.FindElement(By.XPath("//ng-bind[text()='More Options']")).Click();
            IWebElement MoreOptions = driver.FindElement(By.XPath("//ng-bind[text()='More Options']"));
            js.ExecuteScript("arguments[0].click();", MoreOptions);
            Thread.Sleep(4000);            
            js.ExecuteScript("window.scrollBy(0,600)");
            IWebElement Rooms = driver.FindElement(By.XPath("//select[contains(@name,'numrooms')]"));
            SelectElement selectElement = new SelectElement(Rooms);
            selectElement.SelectByIndex(1);
            new SelectElement(driver.FindElement(By.XPath("//select[contains(@name,'adults')]"))).SelectByText("4");
        }
    }
}
