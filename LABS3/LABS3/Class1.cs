using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace LABS3
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void w()
        {
            IWebDriver Chrome = new ChromeDriver();
            Chrome.Navigate().GoToUrl(https://github.com/);

            IWebElement s = Chrome.FindElement(By.XPath(""));

            IWebElement SingInGit = Chrome.FindElement(By.XPath("/ html / body / div[1] / header / div / div[2] / div / span / div / a[1]"));

            
         }
    }
}
