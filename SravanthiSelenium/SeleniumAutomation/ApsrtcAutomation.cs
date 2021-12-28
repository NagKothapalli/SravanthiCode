using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
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
            //driver.Close();
        }
        //WebDriver is an interface  which is implemented by classes like ChromDriver,FirefoxDriver,InternetExplorerDriver ... 
        //WebDriver : GoToUrl, getTitle , getUrl , CurrentWindowHandle , CurrentWindowHandles , minimize , maximize , findElement , findElements , close , quit
        // By : id , name , class , cssSlector , linkText , partialLinkText , tagName , xpath
        //WebElement : click , clear , sendKeys , getText , getAttribute , IsDisplayed , IsEnabled , findElement , findElements
        //Keys : We can click all the keys on the keyboard
        //Exceptions : NoSuchElement , StaleElement , IndexOutOfBounds , NullPointer , 
        //Actions : We can perform all Keyboard operations , all mouse operations
        //How to HandleMultiple Windows
        //How to Handle WebAlert

        //How to Handle Iframe
        //Select [DropDown]: selectByIndex , selectByVisibleText
        //Synchronization : Static Wait  / Implicit Wait / Exlicit Wait
        //Exception Handlng : Try Catch
        //Reading TestData from Config
        //Framework implementation with PageObject Model
        //Running TestCases on multiple browsers
        [TestMethod]
        public void ChildElements()
        {
            Console.WriteLine("Child Element Concept , element inside element");
            driver.FindElement(By.XPath("//input[@name='txtJourneyDate']")).Click();
            IWebElement mytable = driver.FindElement(By.XPath("//table[@class='ui-datepicker-calendar']"));
            IList<IWebElement>     myrows = mytable.FindElements(By.XPath("//tbody/tr"));
            Console.WriteLine("My totlal rows :" + myrows.Count);
            IList<IWebElement> mycolumns = myrows.ElementAt(0).FindElements(By.TagName("td"));
            Console.WriteLine("My totlal columns :" + mycolumns.Count);
        }
        [TestMethod]
        public void KeyBoardAndMouseOperations()
        {
            Console.WriteLine("Test Case : BookTicket");
            //enter from city
            Actions actions = new Actions(driver);
            IWebElement FromCityObject = driver.FindElement(By.XPath("//input[@name='source']"));
            actions.MoveToElement(FromCityObject).Click().SendKeys("HYDERABAD").KeyDown(Keys.ArrowDown).SendKeys(Keys.Enter).Build().Perform();
            //actions.MoveToElement(FromCityObject).Click().SendKeys("HYDERABAD").DoubleClick().ContextClick().KeyDown(Keys.ArrowDown).KeyDown(Keys.ArrowDown).Build().Perform();

            Thread.Sleep(1000);
        }
        [TestMethod]
        public void WorkWithMultipleWindows()
        {
            Console.WriteLine("Test Case : WorkWithMultipleWindows");
            driver.FindElement(By.XPath("//a[@title='TimeTable / Track']")).Click();
            driver.FindElement(By.XPath("//a[text()='All services Time Table & Tracking']")).Click();
            IList<String> mywindows = driver.WindowHandles;
            Console.WriteLine("How many windows :" + mywindows.Count); //2
            driver.SwitchTo().Window(mywindows.ElementAt(1));
            Console.WriteLine("Title of the Second Window :" + driver.Title);
            //driver.Close();            
            driver.SwitchTo().Window(mywindows.ElementAt(0));
            driver.FindElement(By.XPath("//a[@title='Home']")).Click();
            driver.Quit(); // TaskManager : Kill the Process
        }

        [TestMethod]
        public void BookTicket()
        {
            Console.WriteLine("Test Case : BookTicket" );
            //enter from city
            driver.FindElement(By.XPath("//input[@name='source']")).SendKeys("HYDERABAD");
            Actions actions = new Actions(driver);
            Thread.Sleep(1000);
            actions.SendKeys(Keys.Enter).Perform();
            //accept alert
            driver.FindElement(By.XPath("//input[@name='searchBtn']")).Click();
            Thread.Sleep(3000);
            driver.SwitchTo().Alert().Accept();
            //enter to city
            driver.FindElement(By.XPath("//input[@name='destination']")).SendKeys("GUNTUR");
            Thread.Sleep(1000);
            actions.SendKeys(Keys.Enter).Perform();
            //open calender
            driver.FindElement(By.XPath("//input[@name='txtJourneyDate']")).Click();
            //select date
            //driver.FindElement(By.XPath("//a[text()='8']")).Click();
            SelectDate("9");
            driver.FindElement(By.XPath("//input[@name='searchBtn']")).Click();
        }

        public void SelectDate(String JDate)
        {
            driver.FindElement(By.XPath("//a[text()='"+JDate+"']")).Click();  //Dynamic XPATH
            int num = 22;
            String name = "Ravi"+num+"Krishna";
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
