using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestFramework.Tests
{
    /// <summary>
    /// Сводное описание для SmokeTest
    /// </summary>
    [TestClass]
    public class NegativeTests
    {
        private static Steps.Steps steps = new Steps.Steps();

        #region Const string
        private const string FROM = "London Bridge";
        private const string TO = "Liverpool";
        private const string INVALID_Name = "Minsk";
        private const string MISSING_NAME_ERROR_MESSAGE = "Please enter a valid station name or code";
        private const string MISSING_TIME_ERROR_MESSAGE = "Your return journey is earlier than your outward journey";
        private const string MISSING_Chield_ERROR_MESSAGE = "Please select up to 9 travellers";
        private const string MISSING_Via_ERROR_MESSAGE = "Please select Go via or Avoid";
        private const string MISSING_Card_ERROR_MESSAGE = "The number of railcards must not exceed the number of people travelling";
        #endregion

        private TestContext testContextInstance;

        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        [ClassInitialize]
        public static void Init(TestContext testContext)
        {
            steps.InitBrowser();
        }

        [ClassCleanup]
        public static void Cleanup()
        {
            steps.CloseBrowser();
        }

        #region Дополнительные атрибуты тестирования
        //
        // При написании тестов можно использовать следующие дополнительные атрибуты:
        //
        // ClassInitialize используется для выполнения кода до запуска первого теста в классе
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // ClassCleanup используется для выполнения кода после завершения работы всех тестов в классе
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // TestInitialize используется для выполнения кода перед запуском каждого теста 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // TestCleanup используется для выполнения кода после завершения каждого теста
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        #region Test
        [TestMethod]
        public void TestInvalidName()
        {
            steps.InitBrowser();
            steps.SetStation(FROM, INVALID_Name);
            Assert.IsTrue(steps.GetErrorName(MISSING_NAME_ERROR_MESSAGE));
        }

        [TestMethod]
        public void TestInvalidDate()
        {
            steps.InitBrowser();
            steps.SetStation(FROM, TO);
            steps.SetDateReturn(DateTime.Now.AddDays(1));
            steps.SetDateOut(DateTime.Now.AddDays(2));
            Assert.IsTrue(steps.GetErrorTime(MISSING_TIME_ERROR_MESSAGE));
        }

        [TestMethod]
        public void TestInvalidNameVia()
        {
            steps.InitBrowser();
            steps.SetStation(FROM, TO);
            steps.setStationGoVia(INVALID_Name);
            Assert.IsTrue(steps.GetErrorNameVia(MISSING_Via_ERROR_MESSAGE));
        }

        [TestMethod]
        public void TestInvalidChield()
        {
            steps.InitBrowser();
            steps.SetStation(FROM, TO);
            steps.EnterChield(9);
            Assert.IsTrue(steps.GetErrorChield(MISSING_Chield_ERROR_MESSAGE));
        }

        [TestMethod]
        public void TestInvalidCard()
        {
            steps.InitBrowser();
            steps.SetStation(FROM, TO);
            steps.addcard("16-25 Railcard");
            steps.addcard1("16-25 Railcard");
            Assert.IsTrue(steps.GetErrorCard(MISSING_Card_ERROR_MESSAGE));
        }

        [TestMethod]
        public void TestInvalidCardNumber()
        {
            steps.InitBrowser();
            steps.SetStation(FROM, TO);
            steps.addcard("16-25 Railcard",9);
            steps.addcard1("Highland Railcard : North Scotland");
            Assert.IsTrue(steps.GetErrorCard(MISSING_Card_ERROR_MESSAGE));
        }

        [TestMethod]
        public void TestInvalidTimes()
        {
            steps.InitBrowser();
            steps.SetStation(FROM, TO);
            steps.SetDateOut(DateTime.Now.AddDays(3));
            steps.SetDateReturn(DateTime.Now.AddDays(4));
            steps.SetDateOut(DateTime.Now.AddDays(4));
            Assert.IsTrue(steps.GetErrorTime(MISSING_TIME_ERROR_MESSAGE));
        }
        
        [TestMethod]
        public void TestInvalidNumberPessenger()
        {
            steps.InitBrowser();
            steps.SetStation(FROM, TO);
            steps.addcard("16-25 Railcard", 1);
            steps.addcard1("Highland Railcard : North Scotland",2);
            Assert.IsTrue(steps.GetErrorCard(MISSING_Card_ERROR_MESSAGE));
        }

        [TestMethod]
        public void TestInvalidAdults()
        {
            steps.InitBrowser();
            steps.SetStation(FROM, TO);
            steps.EnterChield(1);
            steps.EnterAdults(9);
            Assert.IsTrue(steps.GetErrorChield(MISSING_Chield_ERROR_MESSAGE));
        }

        [TestMethod]
        public void TestInvalidNameOut()
        {
            steps.InitBrowser();
            steps.SetStation(INVALID_Name,FROM);
            Assert.IsTrue(steps.GetErrorNameOut(MISSING_NAME_ERROR_MESSAGE));
        }
        #endregion
    }
}
