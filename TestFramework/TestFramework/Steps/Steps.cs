using System;

using OpenQA.Selenium;


namespace TestFramework.Steps
{
    public class Steps
    {
        IWebDriver driver;
        Pages.MainPage mainPage;

        public void InitBrowser()
        {
            driver = Driver.DriverInstance.GetInstance();
            
        }

        public void CloseBrowser()
        {
            Driver.DriverInstance.CloseBrowser();
        }

        #region GetError
        public bool GetErrorName(string errorMessage)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            mainPage.ButtonSubmitClick();
            return mainPage.GetErrorName(errorMessage);
        }

        public bool GetErrorNameOut(string errorMessage)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            mainPage.ButtonSubmitClick();
            return mainPage.GetErrorNameOut(errorMessage);
        }

        public bool GetErrorNameVia(string errorMessage)
        {
            mainPage.ButtonSubmitClick();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            return mainPage.GetErrorNameVia(errorMessage);
        }

        public bool GetErrorTime(string errorMessage)
        {
             return mainPage.GetErrorTime(errorMessage);
        }

        public bool GetErrorCard(string errorMessage)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            return mainPage.GetErrorCard(errorMessage);
        }


        public bool GetErrorChield(string errorMessage)
        {
            return mainPage.GetErrorChield(errorMessage);
        }
        #endregion

        #region EnterData
        public void SetDateOut(DateTime date)
        {
            mainPage.SetDatepickerOut(date);
        }

        public void SetStation(string fromAirport, string toAirport)
        {
            mainPage = new Pages.MainPage(driver);
            mainPage.OpenPage();
            mainPage.SetStation(fromAirport, toAirport);
        }

        public void SetDateReturn(DateTime date)
        {
            mainPage.RadioButtonReturnClick();
            mainPage.SetDatepickerReturn(date);
        }

        public void setStationGoVia(string name)
        {
            mainPage.ViaButtonClick();
            mainPage.GoVia();
            mainPage.setStationGoVia(name);
        }

        public void EnterChield (int countChield)
        {
            mainPage.ButtonPesengerClick();
            mainPage.chield(countChield);
        }

        public void EnterAdults(int countAdults)
        {
            mainPage.Adults(countAdults);
        }

        public void addcard(string nameCard, int count = 1)
        {
            mainPage.ButtonPesengerClick();
            mainPage.AddCart(nameCard,count);
        }

        public void addcard1(string nameCard, int count = 1)
        {
            mainPage.AddCart1(nameCard,count);
        }
        #endregion
    }
}
