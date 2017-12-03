using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace SeleniumLW4
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        public void TestMethod()
        {
            FirefoxDriver firefoxDriver = new FirefoxDriver();
            firefoxDriver.Navigate().GoToUrl("https://github.com/");
            firefoxDriver.FindElementByXPath(".//a[text() = 'Sign in']").Click();
            firefoxDriver.FindElementById("login_field").SendKeys("vitali_fc_arsenal@mail.ru");
            firefoxDriver.FindElementById("password").SendKeys("****");
            firefoxDriver.FindElementByXPath("/html/body/div[3]/div[1]/div/form/div[4]/input[3]").Click();

        }
    }
}
