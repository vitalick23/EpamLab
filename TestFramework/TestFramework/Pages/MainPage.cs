using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;

namespace TestFramework.Pages
{
    public class MainPage
    {
        private const string BASE_URL = "https://www.thetrainline.com/";

        #region TextBox
        [FindsBy(How = How.XPath, Using = ".//*[@id='from.text']")]
        private IWebElement inputFrom;//*[@id="from.text"]

        [FindsBy(How = How.XPath, Using = ".//*[@id='to.text']")]
        private IWebElement inputTo;//*[@id="to.text"]

        [FindsBy(How = How.XPath, Using = ".//*[@id='viaAvoidStation.text']")]
        private IWebElement inputGoVia; //*[@id="viaAvoidStation.text"]
        #endregion

        #region Error
        [FindsBy(How = How.XPath, Using = "./html/body/div[2]/div/div[1]/div[1]/div/div/div[1]/form/div[1]/div[2]/div/div/div[2]")]
        private IWebElement divErrorName; //html/body/div[2]/div/div[1]/div[1]/div/div/div[1]/form/div[1]/div[2]/div/div/div[2]

        [FindsBy(How = How.XPath, Using ="/html/body/div[2]/div/div[1]/div[1]/div/div/div[1]/form/div[1]/div[1]/div/div/div[2]")]
        private IWebElement divErrorNameOut; //html/body/div[2]/div/div[1]/div[1]/div/div/div[1]/form/div[1]/div[2]/div/div/div[2]

        [FindsBy(How = How.XPath, Using = ".//div[@class='_1cmvtfju']")]
        private IWebElement divErrorNameVia; //div._sw5n5g:nth-child(2) > div:nth-child(1) > div:nth-child(2) > div:nth-child(1) > span:nth-child(1)
        
        [FindsBy(How = How.XPath, Using = "./html/body/div[2]/div/div[1]/div[1]/div/div/div[1]/form/div[3]/fieldset[2]/div[5]/div/div[2]")]
        private IWebElement divErrorTime; //div._1aicgygj:nth-child(1) > div:nth-child(2)

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[1]/div[1]/div/div/div[1]/form/div[4]/div/div/div/div[2]/div/div[2]")]
        private IWebElement divErrorChield; //div._1aicgygj:nth-child(1) > div:nth-child(2)

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[1]/div[1]/div/div/div[1]/form/div[4]/div/div/ul/li[1]/div/div/div[2]")]
        private IWebElement divErrorCard; //div._1aicgygj:nth-child(1) > div:nth-child(2)

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[1]/div[1]/div/div/div[1]/form/div[4]/div/div/ul/li[1]/div/div/div[2]")]
        private IWebElement divErrorCardNumber; //html/body/div[2]/div/div[1]/div[1]/div/div/div[1]/form/div[4]/div/div/ul/li[1]/div/div/div[2]
        #endregion

        #region Buttons
        [FindsBy(How = How.XPath,Using = ".//*[@id='return']")]
        private IWebElement radioButtonReturn; //*[@id="return"]

        [FindsBy(How = How.XPath, Using = "./html/body/div[2]/div/div[1]/div[1]/div/div/div[1]/form/div[3]/fieldset[1]/div[2]/div/div")]
        private IWebElement outDateButton; //html/body/div[2]/div/div[1]/div[1]/div/div/div[1]/form/div[3]/fieldset[1]/div[2]/div/div

        [FindsBy(How = How.XPath, Using = "./html/body/div[2]/div/div[1]/div[1]/div/div/div[1]/form/div[3]/fieldset[2]/div[2]/div[1]/div")]
        private IWebElement ReturnDateButton; //html/body/div[2]/div/div[1]/div[1]/div/div/div[1]/form/div[3]/fieldset[2]/div[2]/div[1]/div

        [FindsBy(How = How.XPath, Using = "./html/body/div[2]/div/div[1]/div[1]/div/div/div[1]/form/div[2]/div[1]/button")]
        private IWebElement ViaButton; //html/body/div[2]/div/div[1]/div[1]/div/div/div[1]/form/div[2]/div[1]/button
        
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[1]/div[1]/div/div/div[1]/form/div[4]/button/div[2]")]
        private IWebElement ButtonPessenger; //*[@id="passenger-summary-btn"]
        
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[1]/div[1]/div/div/div[1]/form/div[4]/div/div/ul/li/button")]
        private IWebElement ButtonAddRailcard; //html/body/div[2]/div/div[1]/div[1]/div/div/div[1]/form/div[4]/div/div/ul/li/button

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[1]/div[1]/div/div/div[1]/form/div[4]/div/div/ul/li/button")]
        private IWebElement ButtonAddRailcard1; //html/body/div[2]/div/div[1]/div[1]/div/div/div[1]/form/div[4]/div/div/ul/li/button

        [FindsBy(How = How.XPath, Using = "./html/body/div[2]/div/div[1]/div[1]/div/div/div[1]/form/div[5]/button")]
        private IWebElement buttonSelectDates;  //html/body/div[2]/div/div[1]/div[1]/div/div/div[1]/form/div[5]/button
        #endregion

        private IWebDriver driver;

        public MainPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this.driver, this);
        }

        public void OpenPage()
        {
            driver.Navigate().GoToUrl(BASE_URL);
            System.Console.WriteLine("Main page opened");
        }
        
        #region buttonClick
        public void ButtonPesengerClick()
        {
            ButtonPessenger.Click();
        }

        public void RadioButtonReturnClick()
        {
            radioButtonReturn.Click();
        }

        public void ViaButtonClick()
        {
            ViaButton.Click();
        }

        public void ButtonSubmitClick()
        {
            buttonSelectDates.Click();
        }
        #endregion

        #region GetError
        public bool GetErrorTime(string errorMessage)
        {
            return divErrorTime.Text == errorMessage;
        }

        public bool GetErrorCard(string errorMessage)
        {
            return divErrorCard.Text == errorMessage;
        }

        public bool GetErrorName(string errorMessage)
        {
            return divErrorName.Text == errorMessage;
        }

        public bool GetErrorNameOut(string errorMessage)
        {
            return divErrorNameOut.Text == errorMessage;
        }
        public bool GetErrorCartNumber(string errorMessage)
        {
            return divErrorCardNumber.Text == errorMessage;
        }

        public bool GetErrorNameVia(string errorMessage)
        {
            return divErrorNameVia.Text == errorMessage;
        }

        public bool GetErrorChield(string errorMessage)
        {
            return divErrorChield.Text == errorMessage;
        }
        #endregion

        #region SetData
        public void SetStation(string from, string to)
        {
            inputFrom.SendKeys(from);
            inputTo.SendKeys(to);
        }

        public void setStationGoVia(string name)
        {
            inputGoVia.SendKeys(name);
        }

        public void chield(int countChield)
        {
            if (countChield <= 9)
            {
                IWebElement col = driver.FindElement(By.XPath("/html/body/div[2]/div/div[1]/div[1]/div/div/div[1]/form/div[4]/div/div/div/div[1]/div[2]/div/select"));
                SelectElement sl = new SelectElement(col);
                sl.SelectByText(Convert.ToString(countChield));
            }
        }

        public void Adults(int countAdults)
        {
            if (countAdults <= 9)
            {
                IWebElement col = driver.FindElement(By.XPath("/html/body/div[2]/div/div[1]/div[1]/div/div/div[1]/form/div[4]/div/div/div/div[1]/div[1]/div/select"));
                SelectElement sl = new SelectElement(col);
                sl.SelectByText(Convert.ToString(countAdults));
            }
        }
        
        public void AddCart(string namecard,int count = 1)
        {
            ButtonAddRailcard.Click();
            IWebElement col = driver.FindElement(By.XPath("/html/body/div[2]/div/div[1]/div[1]/div/div/div[1]/form/div[4]/div/div/ul/div/div/div/li/div[1]/select"));
            SelectElement sl = new SelectElement(col);
            sl.SelectByText(namecard);
            if(count != 1)
            {
                IWebElement cou = driver.FindElement(By.XPath("/html/body/div[2]/div/div[1]/div[1]/div/div/div[1]/form/div[4]/div/div/ul/div[1]/div/div/li/div[2]/select"));
                SelectElement se = new SelectElement(cou);
                se.SelectByText(Convert.ToString(count));
            }
        }

        public void AddCart1(string namecard, int count = 1)
        {
            ButtonAddRailcard1.Click();
            IWebElement col = driver.FindElement(By.XPath("/html/body/div[2]/div/div[1]/div[1]/div/div/div[1]/form/div[4]/div/div/ul/div[2]/div/div/li/div[1]/select"));
            SelectElement sl = new SelectElement(col);
            sl.SelectByText(Convert.ToString(namecard));
            if (count != 1)
            {
                IWebElement cou = driver.FindElement(By.XPath("/html/body/div[2]/div/div[1]/div[1]/div/div/div[1]/form/div[4]/div/div/ul/div[2]/div/div/li/div[2]/select"));
                SelectElement se = new SelectElement(cou);
                se.SelectByText(Convert.ToString(count));
            }
        }

        public void SetDatepickerOut(DateTime date)
        {
            outDateButton.Click();
            string dayNumberAsString = date.Day.ToString(); 
            IWebElement dayButton = driver.FindElement(By.XPath("//div[@class='_i6lz8s']//a[text()='" + dayNumberAsString + "']"));
            dayButton.Click();
        }

        public void SetDatepickerReturn(DateTime date)
        {
            ReturnDateButton.Click();
            string dayNumberAsString = date.Day.ToString();
            IWebElement dayButton = driver.FindElement(By.XPath("//div[@class='_i6lz8s']//a[text()='" + dayNumberAsString + "']"));
            dayButton.Click(); 
        }

        public void GoVia()
        {
            IWebElement button = driver.FindElement(By.CssSelector("._mxvwsqNaN > svg:nth-child(2)"));
            button.Click();
            button = driver.FindElement(By.CssSelector("._mxvwsqNaN > svg:nth-child(2)"));
            button.Click();
        }
        #endregion
    }
}
