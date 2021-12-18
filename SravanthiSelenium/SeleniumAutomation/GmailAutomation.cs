﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SravanthiSelenium.SeleniumAutomation
{
    [TestClass]
    public class GmailAutomation
    {
        String ExpectedTitle = "Gmail";
        ChromeDriver driver;
        public GmailAutomation()
        {
            driver = new ChromeDriver();
        }

        [TestMethod]
        public void LaunchApplication()
        {
            Console.WriteLine("RC : LaunchApplication");            
            driver.Navigate().GoToUrl("https://gmail.com");
            String ActualTitle = driver.Title;
            Console.WriteLine("Title of browser :" + ActualTitle);
            Console.WriteLine("Currnet URL :" + driver.Url);
            Console.WriteLine("Session ID of my window" + driver.CurrentWindowHandle);
            if(ExpectedTitle.Equals(ActualTitle))
            {
                Console.WriteLine("Title Validation Passed");
            }
            else
            {
                Console.WriteLine("Title Validation Failed");
            }
            Assert.AreEqual(ExpectedTitle, ActualTitle);            
        }
        [TestMethod]
        public void LoginToApplication()
        {
            LaunchApplication();
            Console.WriteLine("RC : LoginToApplication ");
            driver.FindElement(By.Name("identifier")).Click();
            driver.FindElement(By.Name("identifier")).SendKeys("dfdgfdghghgfh");
            driver.FindElement(By.Name("identifier")).Clear();
            driver.FindElement(By.Id("identifierId")).SendKeys("nag022@gmail.com");
            driver.FindElement(By.ClassName("VfPpkd-vQzf8d")).Click();
            
        }
        //Relative XPATH
        //tagName[@attribute=value]
        //tagName[text()=value]
        //*[@attribute=value]
        //*[text()=value]
        //tagName[contains(@attribute,value)]
        //tagName[contains(text(),value)]
        //*[contains(@attribute,value)]
        //*[contains(text(),value)]

        //tagName[@attribute1=value  and @attribute2=value]     -  //student[@fname=ram  and @lname=krishna]
        //tagName[text()=value]
        //*[@attribute=value]
        //*[text()=value]
        //tagName[contains(@attribute,value)]
        //tagName[contains(text(),value)]
        //*[contains(@attribute,value)]
        //*[contains(text(),value)]
        [TestMethod]
        public void ForgotEmail()
        {
            LaunchApplication();
            Console.WriteLine("RC : ForgotEmail ");
            // / html / body / div[1] / div[1] / div[2] / div / div[2] / div / div / div[2] / div / div[1] / div / form / span / section / div / div / div[3] / button
            // driver.FindElement(By.TagName("button")).Click();
            //Static /fixed / absolute
            //driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[2]/div/div[2]/div/div/div[2]/div/div[1]/div/form/span/section/div/div/div[3]/button")).Click();
            //driver.FindElement(By.XPath("//button[@jsname='Cuz2Ue']")).Click();
            //driver.FindElement(By.XPath("//button[text()='Forgot email?']")).Click();
            //driver.FindElement(By.XPath("//*[@jsname='Cuz2Ue']")).Click();
            //driver.FindElement(By.XPath("//*[text()='Forgot email?']")).Click();
            //driver.FindElement(By.XPath("//button[contains(text(),'Forgot')]")).Click();
            driver.FindElement(By.XPath("//button[@type='button' and @jsname='Cuz2Ue']")).Click();
        }
        [TestMethod]
        public void LearnMore()
        {
            LaunchApplication();
            Console.WriteLine("RC : LearnMore ");
            driver.FindElement(By.TagName("a")).Click();
        }
        [TestMethod]
        public void Help()
        {
            LaunchApplication();
            Console.WriteLine("RC : Help ");
            driver.FindElement(By.LinkText("Help")).Click();
        }
        [TestMethod]
        public void Privacy()
        {
            LaunchApplication();
            Console.WriteLine("RC : Privacy ");
            driver.FindElement(By.LinkText("Privacy")).Click();
        }
        [TestMethod]
        public void Terms()
        {
            LaunchApplication();
            Console.WriteLine("RC : Terms ");
            driver.FindElement(By.LinkText("Terms")).Click();
        }
        
        [TestMethod]
        public void CreateAccount()
        {
            LaunchApplication();
            Console.WriteLine("RC : Terms ");
            driver.FindElement(By.XPath("//span[@class='VfPpkd-vQzf8d' and text()='Create account']")).Click();
        }
    }
}
